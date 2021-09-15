using Colyseus.Schema;

public class State : Schema
{
	[Type(1, "array", "int16")]
	public ArraySchema<short> player1Shots = new ArraySchema<short>();

	[Type(2, "array", "int16")]
	public ArraySchema<short> player2Shots = new ArraySchema<short>();

	[Type(3, "array", "int16")]
	public ArraySchema<short> player3Shots = new ArraySchema<short>();

	[Type(4, "array", "int16")]
	public ArraySchema<short> player4Shots = new ArraySchema<short>();
}
