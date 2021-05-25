public static class AudioDevice // TypeDefIndex: 11708
{
	// Fields
	public const float OutputVolumeMax = 128;
	public const float OutputVolumeMin = 0;

	// Methods

	// RVA: 0x26A6C50 Offset: 0x26A6D51 VA: 0x26A6C50
	public static extern bool SetOutputVolume(AudioDevice.AudioDeviceName deviceName, float volume) { }
}

