using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Run a dotnet project", Line="dotnet run", Platform=".NET 6"},
                new Command{Id=1, HowTo="Run a docker container", Line="docker compose up", Platform="Docker"},
                new Command{Id=2, HowTo="Run a Kubernetes", Line="kubectl apply -f 'nameofproject'", Platform="Kubernetes"},
                new Command{Id=3, HowTo="Run a node.js project", Line="npm run dev", Platform="Node"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Run a dotnet project", Line="dotnet run", Platform=".NET 6"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}