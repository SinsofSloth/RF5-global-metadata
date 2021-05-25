[FlagsAttribute] // RVA: 0x1064F0 Offset: 0x1065F1 VA: 0x1064F0
internal enum AvailableTrackingData // TypeDefIndex: 3720
{
	// Fields
	public int value__; // 0x0
	public const AvailableTrackingData None = 0;
	public const AvailableTrackingData PositionAvailable = 1;
	public const AvailableTrackingData RotationAvailable = 2;
	public const AvailableTrackingData VelocityAvailable = 4;
	public const AvailableTrackingData AngularVelocityAvailable = 8;
	public const AvailableTrackingData AccelerationAvailable = 16;
	public const AvailableTrackingData AngularAccelerationAvailable = 32;
}

