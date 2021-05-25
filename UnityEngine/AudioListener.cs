[RequireComponent] // RVA: 0xF0FD0 Offset: 0xF10D1 VA: 0xF0FD0
[StaticAccessorAttribute] // RVA: 0xF0FD0 Offset: 0xF10D1 VA: 0xF0FD0
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 3567
{
	// Properties
	public static float volume { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2050 Offset: 0xF2151 VA: 0xF2050
	public static bool pause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0xF1950 Offset: 0xF1A51 VA: 0xF1950
	// RVA: 0x1BB3B70 Offset: 0x1BB3C71 VA: 0x1BB3B70
	private static void GetOutputDataHelper([Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0xF1960 Offset: 0xF1A61 VA: 0xF1960
	// RVA: 0x1BB3BC0 Offset: 0x1BB3CC1 VA: 0x1BB3BC0
	private static void GetSpectrumDataHelper([Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB3C20 Offset: 0x1BB3D21 VA: 0x1BB3C20
	public static float get_volume() { }

	// RVA: 0x1BB3C60 Offset: 0x1BB3D61 VA: 0x1BB3C60
	public static void set_volume(float value) { }

	// RVA: 0x1BB3CB0 Offset: 0x1BB3DB1 VA: 0x1BB3CB0
	public static bool get_pause() { }

	// RVA: 0x1BB3CF0 Offset: 0x1BB3DF1 VA: 0x1BB3CF0
	public static void set_pause(bool value) { }

	// RVA: 0x1BB3D40 Offset: 0x1BB3E41 VA: 0x1BB3D40
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1BB3D90 Offset: 0x1BB3E91 VA: 0x1BB3D90
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	[ObsoleteAttribute] // RVA: 0xF1970 Offset: 0xF1A71 VA: 0xF1970
	// RVA: 0x1BB3DE0 Offset: 0x1BB3EE1 VA: 0x1BB3DE0
	public static float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1BB3E80 Offset: 0x1BB3F81 VA: 0x1BB3E80
	public static void GetOutputData(float[] samples, int channel) { }

	[ObsoleteAttribute] // RVA: 0xF19B0 Offset: 0xF1AB1 VA: 0xF19B0
	// RVA: 0x1BB3ED0 Offset: 0x1BB3FD1 VA: 0x1BB3ED0
	public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1BB3F70 Offset: 0x1BB4071 VA: 0x1BB3F70
	public static void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB3FD0 Offset: 0x1BB40D1 VA: 0x1BB3FD0
	public void .ctor() { }
}

