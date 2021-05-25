[Serializable]
public struct WeatherData // TypeDefIndex: 6884
{
	// Fields
	public byte WeatherId; // 0x0
	public byte WeatherDayId; // 0x1
	public byte TodayRate; // 0x2
	public byte TyphoonDayCount; // 0x3
	public byte RuneyDayCount; // 0x4
	public byte MeteorShowerDayCount; // 0x5
	public byte NextWeatherDayId; // 0x6
	public byte[] WeatherHour; // 0x8

	// Methods

	// RVA: 0x2DF360 Offset: 0x2DF461 VA: 0x2DF360
	public void Initalize() { }

	// RVA: 0x2DF370 Offset: 0x2DF471 VA: 0x2DF370
	public void Writer(BinaryWriter writer) { }

	// RVA: 0x2DF380 Offset: 0x2DF481 VA: 0x2DF380
	public void Reader0000(BinaryReader reader) { }
}

