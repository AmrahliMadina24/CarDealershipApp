public class Car
{
	private static int idCounter = 1; 
	public int Id { get; set; }
	public string Brand { get; set; }
	public string Model { get; set; }

	public Car() { }

	public Car(string brand , string model)
	{
		Brand = brand;
		Model = model;
	}
	
}