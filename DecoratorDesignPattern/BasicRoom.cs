using System;

namespace DecoratorDesignPattern
{
	/// <summary>
	/// This is a concrete class that implements the IRoom interface and is sealed and cannot be extended.
	/// </summary>
	public sealed class BasicRoom : IRoom
	{
		public void GetRoom()
		{
			Console.WriteLine("Basic-Room allotted with free amenities");
		}
	}
}


