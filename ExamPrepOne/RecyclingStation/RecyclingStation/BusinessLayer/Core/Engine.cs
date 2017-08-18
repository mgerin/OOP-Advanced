namespace RecyclingStation.BusinessLayer.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using BusinessLayer.Contracts.IO;
    using BusinessLayer.Contracts.Core;

    public class Engine : IEngine
    {
        private const string TerminatingCommand = "TimeToRecycle";

        private readonly MethodInfo[] RecyclingStationMethods;

        private IReader reader;

        private IWriter writer;

        private IRecyclingStation recyclingStation;

        public Engine(IReader reader, IWriter writer, IRecyclingStation recyclingStation)
        {
            this.Reader = reader;
            this.Writer = writer;
            this.RecyclingStation = recyclingStation;
            this.RecyclingStationMethods = this.RecyclingStation.GetType().GetMethods();
        }

        public IRecyclingStation RecyclingStation { get => this.recyclingStation; set => this.recyclingStation = value; }
        private IReader Reader
        {
            get => this.reader;

            set => this.reader = value;
        }

        private IWriter Writer
        {
            get => this.writer;

            set => this.writer = value;
        }

        private string[] SplitStringByChar(string toSplit, params char[] toSplitBy)
        {
            return toSplit.Split(toSplitBy, StringSplitOptions.RemoveEmptyEntries);
        }

        public void Run()
        {
            string inputLine;

            while ((inputLine = this.Reader.ReadLine()) != TerminatingCommand)
            {
                string[] commandArgs = this.SplitStringByChar(inputLine, ' ');

                string methodName = commandArgs[0];
                string[] methodNonParsedParams = this.SplitStringByChar(commandArgs[1], '|');

                MethodInfo methodToInvoke =
                    this.RecyclingStationMethods.FirstOrDefault(
                        m => m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase));

                ParameterInfo[] methodParams = methodToInvoke.GetParameters();

                object[] parsedParams = new object[methodParams.Length];
                for (int currentConvertion = 0; currentConvertion < methodParams.Length; currentConvertion++)
                {
                    Type currentParamType = methodParams[currentConvertion].ParameterType;
                }
                // .Invoke()
            }
        }
    }
}
