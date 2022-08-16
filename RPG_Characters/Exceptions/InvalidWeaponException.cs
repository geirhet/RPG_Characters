using System;


namespace RPG_Characters.Exceptions
{
	public class InvalidWeaponException : Exception
	{
		/// <summary>
		/// Custom exception for errors with weapon items.
		/// </summary>
		/// <param name="message"></param>
		public InvalidWeaponException(string? message) : base(message)
		{
		}
	}
}
