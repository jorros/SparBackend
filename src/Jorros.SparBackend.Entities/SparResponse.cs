namespace Jorros.SparBackend.Entities
{
	public abstract class SparResponse
	{
		public string ErrorMessage { get; set; }

		public bool Succeeded { get; set; }
	}
}
