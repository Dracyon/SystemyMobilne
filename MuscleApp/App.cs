using System;

namespace MuscleApp
{
    public class App
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "http://localhost:5000";

        public static void Initialize()
        {
            if (UseMockDataStore)
                ServiceLocator.Instance.Register<IDataStore<TrainingEntity>, MockDataStore>();
            else
                ServiceLocator.Instance.Register<IDataStore<TrainingEntity>, CloudDataStore>();
        }
    }
}
