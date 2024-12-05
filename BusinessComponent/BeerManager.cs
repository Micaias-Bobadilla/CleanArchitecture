namespace BusinessComponent
{
    public class BeerManager
    {
        private IRepository _repository;

        public BeerManager(IRepository repository)
        {
            _repository = repository;
        }
        public void add(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            _repository.add(name);
        }

        public string Get()
            => "Las cerveas son: " + _repository.Get();
    }
}
