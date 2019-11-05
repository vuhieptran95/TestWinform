using Newtonsoft.Json;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp.Entities.Config;
using WinformApp.Entities.Helpers;
using WinformApp.Entities.Responses;
using WinformApp.Entities.Services.ChannelAdvisor;
using WinformApp.Entities.Services.Integration;
using WinformApp.Entities.Services.PartCenter;

namespace ConsoleAppClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var partcenterService = new IntegrationService(new PartCenterService(), new ChannelAdvisorService());

            // Check if file exist?

            var filePath = "Config/ScheduleConfig2.json";


            var configResponse = await ConfigHelper.ReloadConfigAsync<BaseConfigFile>(filePath);
            var config = configResponse.Payload;

            //await RunProgram();

            Console.ReadKey();
        }

        private static async Task RunProgram()
        {
            try
            {
                // Grab the Scheduler instance from the Factory
                NameValueCollection props = new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                };
                StdSchedulerFactory factory = new StdSchedulerFactory(props);
                IScheduler scheduler = await factory.GetScheduler();

                await scheduler.Start();

                var ebayJob = JobBuilder.Create<EbayJob>()
                    .WithIdentity("ebay", "ebaygroup")
                    .Build();

                var trigger = TriggerBuilder.Create()
                    .WithIdentity("ebaytrigger", "ebaygroup")
                    .StartNow()
                    .WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever())
                    .Build();


                await scheduler.ScheduleJob(ebayJob, trigger);

                await Task.Delay(TimeSpan.FromSeconds(60));

                await scheduler.Shutdown();


            }
            catch (SchedulerException se)
            {
                await Console.Error.WriteLineAsync(se.ToString());
            }
        }
    }

    public class EbayJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }
    }
}
