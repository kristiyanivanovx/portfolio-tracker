namespace PT.Data.Seeders.Contracts
{
	internal interface ISeeder<T>
	{
		public IEnumerable<T> Seed() { throw new NotImplementedException(); }
	}
}
