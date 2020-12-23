using System;

namespace DecoratorDesignPattern
{
	/// <summary>
	/// This is the concrete class that implements the RoomDecorator base class and provides the additional 
	/// functionality of upgrading the room to Executive class (just mocking the functionality) 
	/// by overriding the GetRoom() method.
	/// </summary>
	public class ExecutiveRoom : RoomDecorator
	{
		public ExecutiveRoom(IRoom room) : base(room)
		{

		}

		public override void GetRoom()
		{
			Console.WriteLine("Room upgraded from Basic to Executive-Type");
			Console.WriteLine(" -- Addon services: Breakfast, Unlimited Drinks and free access to lounge");
		}
	}
}


