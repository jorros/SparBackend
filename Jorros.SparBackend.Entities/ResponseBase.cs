namespace Jorros.SparBackend.Entities
{
    public abstract class ResponseBase
    {
		public string ErrorMessage { get; set; }

		public bool Succeeded { get; set; }
	}
}
