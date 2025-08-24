namespace PT.Services.Messaging
{
	public enum BusinessStatusCodeEnum
	{
		None = 0,
		Success = 200,
		MissingObject = 404,
		ObjectAlreadyExists = 409,
		InternalServerError = 500,
	}
}
