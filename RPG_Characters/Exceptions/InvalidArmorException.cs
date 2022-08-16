using System;


namespace RPG_Characters.Exceptions
{
	public class InvalidArmorException : Exception
	{
		/// <summary>
		/// Custom exception for errors with armor items.
		/// </summary>
		/// <param name="message"></param>
		public InvalidArmorException(string? message) : base(message)
		{
		}
	}
}
