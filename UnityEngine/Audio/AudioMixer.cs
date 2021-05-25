[NativeHeaderAttribute] // RVA: 0xF11B0 Offset: 0xF12B1 VA: 0xF11B0
[ExcludeFromPresetAttribute] // RVA: 0xF11B0 Offset: 0xF12B1 VA: 0xF11B0
[ExcludeFromObjectFactoryAttribute] // RVA: 0xF11B0 Offset: 0xF12B1 VA: 0xF11B0
[NativeHeaderAttribute] // RVA: 0xF11B0 Offset: 0xF12B1 VA: 0xF11B0
public class AudioMixer : Object // TypeDefIndex: 3571
{
	// Properties
	[NativePropertyAttribute] // RVA: 0xF2290 Offset: 0xF2391 VA: 0xF2290
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	[NativePropertyAttribute] // RVA: 0xF22A0 Offset: 0xF23A1 VA: 0xF22A0
	public AudioMixerUpdateMode updateMode { get; set; }

	// Methods

	// RVA: 0x1BB1250 Offset: 0x1BB1351 VA: 0x1BB1250
	internal void .ctor() { }

	// RVA: 0x1BB12C0 Offset: 0x1BB13C1 VA: 0x1BB12C0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1BB1310 Offset: 0x1BB1411 VA: 0x1BB1310
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[NativeMethodAttribute] // RVA: 0xF1C20 Offset: 0xF1D21 VA: 0xF1C20
	// RVA: 0x1BB1360 Offset: 0x1BB1461 VA: 0x1BB1360
	public AudioMixerSnapshot FindSnapshot(string name) { }

	[NativeMethodAttribute] // RVA: 0xF1C60 Offset: 0xF1D61 VA: 0xF1C60
	// RVA: 0x1BB13B0 Offset: 0x1BB14B1 VA: 0x1BB13B0
	public AudioMixerGroup[] FindMatchingGroups(string subPath) { }

	// RVA: 0x1BB1400 Offset: 0x1BB1501 VA: 0x1BB1400
	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0xF1CB0 Offset: 0xF1DB1 VA: 0xF1CB0
	// RVA: 0x1BB16F0 Offset: 0x1BB17F1 VA: 0x1BB16F0
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0xF1CF0 Offset: 0xF1DF1 VA: 0xF1CF0
	// RVA: 0x1BB1750 Offset: 0x1BB1851 VA: 0x1BB1750
	public void TransitionToSnapshots(AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach) { }

	// RVA: 0x1BB17C0 Offset: 0x1BB18C1 VA: 0x1BB17C0
	public AudioMixerUpdateMode get_updateMode() { }

	// RVA: 0x1BB1810 Offset: 0x1BB1911 VA: 0x1BB1810
	public void set_updateMode(AudioMixerUpdateMode value) { }

	[NativeMethodAttribute] // RVA: 0xF1D40 Offset: 0xF1E41 VA: 0xF1D40
	// RVA: 0x1BB1860 Offset: 0x1BB1961 VA: 0x1BB1860
	public bool SetFloat(string name, float value) { }

	[NativeMethodAttribute] // RVA: 0xF1D50 Offset: 0xF1E51 VA: 0xF1D50
	// RVA: 0x1BB18C0 Offset: 0x1BB19C1 VA: 0x1BB18C0
	public bool ClearFloat(string name) { }

	[NativeMethodAttribute] // RVA: 0xF1D60 Offset: 0xF1E61 VA: 0xF1D60
	// RVA: 0x1BB1910 Offset: 0x1BB1A11 VA: 0x1BB1910
	public bool GetFloat(string name, out float value) { }
}

