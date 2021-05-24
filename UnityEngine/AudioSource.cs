[StaticAccessorAttribute] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
[RequireComponent] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 3568
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2090 Offset: 0xF2191 VA: 0xF2090
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xF20D0 Offset: 0xF21D1 VA: 0xF20D0
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2110 Offset: 0xF2211 VA: 0xF2110
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2150 Offset: 0xF2251 VA: 0xF2150
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2190 Offset: 0xF2291 VA: 0xF2190
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[ObsoleteAttribute] // RVA: 0xF21D0 Offset: 0xF22D1 VA: 0xF21D0
	public float minVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2210 Offset: 0xF2311 VA: 0xF2210
	public float maxVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2250 Offset: 0xF2351 VA: 0xF2250
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x1BB4550 Offset: 0x1BB4651 VA: 0x1BB4550
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1BB45A0 Offset: 0x1BB46A1 VA: 0x1BB45A0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1BB45F0 Offset: 0x1BB46F1 VA: 0x1BB45F0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x1BB4640 Offset: 0x1BB4741 VA: 0x1BB4640
	private void Play(double delay) { }

	// RVA: 0x1BB4690 Offset: 0x1BB4791 VA: 0x1BB4690
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB46F0 Offset: 0x1BB47F1 VA: 0x1BB46F0
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0xF19F0 Offset: 0xF1AF1 VA: 0xF19F0
	// RVA: 0x1BB4740 Offset: 0x1BB4841 VA: 0x1BB4740
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB47A0 Offset: 0x1BB48A1 VA: 0x1BB47A0
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x1BB47F0 Offset: 0x1BB48F1 VA: 0x1BB47F0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0xF1A00 Offset: 0xF1B01 VA: 0xF1A00
	// RVA: 0x1BB4850 Offset: 0x1BB4951 VA: 0x1BB4850
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB48C0 Offset: 0x1BB49C1 VA: 0x1BB48C0
	public float get_volume() { }

	// RVA: 0x1BB4910 Offset: 0x1BB4A11 VA: 0x1BB4910
	public void set_volume(float value) { }

	// RVA: 0x1BB4960 Offset: 0x1BB4A61 VA: 0x1BB4960
	public float get_pitch() { }

	// RVA: 0x1BB49B0 Offset: 0x1BB4AB1 VA: 0x1BB49B0
	public void set_pitch(float value) { }

	// RVA: 0x1BB4A00 Offset: 0x1BB4B01 VA: 0x1BB4A00
	public float get_time() { }

	// RVA: 0x1BB4A50 Offset: 0x1BB4B51 VA: 0x1BB4A50
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0xF1A10 Offset: 0xF1B11 VA: 0xF1A10
	// RVA: 0x1BB4AA0 Offset: 0x1BB4BA1 VA: 0x1BB4AA0
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0xF1A50 Offset: 0xF1B51 VA: 0xF1A50
	// RVA: 0x1BB4AF0 Offset: 0x1BB4BF1 VA: 0x1BB4AF0
	public void set_timeSamples(int value) { }

	// RVA: 0x1BB4B40 Offset: 0x1BB4C41 VA: 0x1BB4B40
	public AudioClip get_clip() { }

	// RVA: 0x1BB4B90 Offset: 0x1BB4C91 VA: 0x1BB4B90
	public void set_clip(AudioClip value) { }

	// RVA: 0x1BB4BE0 Offset: 0x1BB4CE1 VA: 0x1BB4BE0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1BB4C30 Offset: 0x1BB4D31 VA: 0x1BB4C30
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1A90 Offset: 0xF1B91 VA: 0xF1A90
	// RVA: 0x1BB4C80 Offset: 0x1BB4D81 VA: 0x1BB4C80
	public void Play() { }

	// RVA: 0x1BB4CD0 Offset: 0x1BB4DD1 VA: 0x1BB4CD0
	public void Play(ulong delay) { }

	// RVA: 0x1BB4D20 Offset: 0x1BB4E21 VA: 0x1BB4D20
	public void PlayDelayed(float delay) { }

	// RVA: 0x1BB4D90 Offset: 0x1BB4E91 VA: 0x1BB4D90
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1AA0 Offset: 0xF1BA1 VA: 0xF1AA0
	// RVA: 0x1BB4DF0 Offset: 0x1BB4EF1 VA: 0x1BB4DF0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1BB4E00 Offset: 0x1BB4F01 VA: 0x1BB4E00
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB4F00 Offset: 0x1BB5001 VA: 0x1BB4F00
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x1BB4F50 Offset: 0x1BB5051 VA: 0x1BB4F50
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x1BB4FA0 Offset: 0x1BB50A1 VA: 0x1BB4FA0
	public void Stop() { }

	// RVA: 0x1BB4FF0 Offset: 0x1BB50F1 VA: 0x1BB4FF0
	public void Pause() { }

	// RVA: 0x1BB5040 Offset: 0x1BB5141 VA: 0x1BB5040
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xF1AB0 Offset: 0xF1BB1 VA: 0xF1AB0
	// RVA: 0x1BB5090 Offset: 0x1BB5191 VA: 0x1BB5090
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xF1AF0 Offset: 0xF1BF1 VA: 0xF1AF0
	// RVA: 0x1BB50E0 Offset: 0x1BB51E1 VA: 0x1BB50E0
	public bool get_isVirtual() { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1B30 Offset: 0xF1C31 VA: 0xF1B30
	// RVA: 0x1BB5130 Offset: 0x1BB5231 VA: 0x1BB5130
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x1BB5140 Offset: 0x1BB5241 VA: 0x1BB5140
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x1BB53F0 Offset: 0x1BB54F1 VA: 0x1BB53F0
	public bool get_loop() { }

	// RVA: 0x1BB5440 Offset: 0x1BB5541 VA: 0x1BB5440
	public void set_loop(bool value) { }

	// RVA: 0x1BB5490 Offset: 0x1BB5591 VA: 0x1BB5490
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x1BB54E0 Offset: 0x1BB55E1 VA: 0x1BB54E0
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x1BB5530 Offset: 0x1BB5631 VA: 0x1BB5530
	public bool get_playOnAwake() { }

	// RVA: 0x1BB5580 Offset: 0x1BB5681 VA: 0x1BB5580
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BB55D0 Offset: 0x1BB56D1 VA: 0x1BB55D0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x1BB5620 Offset: 0x1BB5721 VA: 0x1BB5620
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x1BB5670 Offset: 0x1BB5771 VA: 0x1BB5670
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1BB56C0 Offset: 0x1BB57C1 VA: 0x1BB56C0
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x1BB5710 Offset: 0x1BB5811 VA: 0x1BB5710
	public float get_panStereo() { }

	// RVA: 0x1BB5760 Offset: 0x1BB5861 VA: 0x1BB5760
	public void set_panStereo(float value) { }

	// RVA: 0x1BB57B0 Offset: 0x1BB58B1 VA: 0x1BB57B0
	public float get_spatialBlend() { }

	// RVA: 0x1BB53A0 Offset: 0x1BB54A1 VA: 0x1BB53A0
	public void set_spatialBlend(float value) { }

	// RVA: 0x1BB5800 Offset: 0x1BB5901 VA: 0x1BB5800
	public bool get_spatialize() { }

	// RVA: 0x1BB5850 Offset: 0x1BB5951 VA: 0x1BB5850
	public void set_spatialize(bool value) { }

	// RVA: 0x1BB58A0 Offset: 0x1BB59A1 VA: 0x1BB58A0
	public bool get_spatializePostEffects() { }

	// RVA: 0x1BB58F0 Offset: 0x1BB59F1 VA: 0x1BB58F0
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x1BB5940 Offset: 0x1BB5A41 VA: 0x1BB5940
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB59A0 Offset: 0x1BB5AA1 VA: 0x1BB59A0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x1BB59F0 Offset: 0x1BB5AF1 VA: 0x1BB59F0
	public float get_reverbZoneMix() { }

	// RVA: 0x1BB5A40 Offset: 0x1BB5B41 VA: 0x1BB5A40
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x1BB5A90 Offset: 0x1BB5B91 VA: 0x1BB5A90
	public bool get_bypassEffects() { }

	// RVA: 0x1BB5AE0 Offset: 0x1BB5BE1 VA: 0x1BB5AE0
	public void set_bypassEffects(bool value) { }

	// RVA: 0x1BB5B30 Offset: 0x1BB5C31 VA: 0x1BB5B30
	public bool get_bypassListenerEffects() { }

	// RVA: 0x1BB5B80 Offset: 0x1BB5C81 VA: 0x1BB5B80
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x1BB5BD0 Offset: 0x1BB5CD1 VA: 0x1BB5BD0
	public bool get_bypassReverbZones() { }

	// RVA: 0x1BB5C20 Offset: 0x1BB5D21 VA: 0x1BB5C20
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x1BB5C70 Offset: 0x1BB5D71 VA: 0x1BB5C70
	public float get_dopplerLevel() { }

	// RVA: 0x1BB5CC0 Offset: 0x1BB5DC1 VA: 0x1BB5CC0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x1BB5D10 Offset: 0x1BB5E11 VA: 0x1BB5D10
	public float get_spread() { }

	// RVA: 0x1BB5D60 Offset: 0x1BB5E61 VA: 0x1BB5D60
	public void set_spread(float value) { }

	// RVA: 0x1BB5DB0 Offset: 0x1BB5EB1 VA: 0x1BB5DB0
	public int get_priority() { }

	// RVA: 0x1BB5E00 Offset: 0x1BB5F01 VA: 0x1BB5E00
	public void set_priority(int value) { }

	// RVA: 0x1BB5E50 Offset: 0x1BB5F51 VA: 0x1BB5E50
	public bool get_mute() { }

	// RVA: 0x1BB5EA0 Offset: 0x1BB5FA1 VA: 0x1BB5EA0
	public void set_mute(bool value) { }

	// RVA: 0x1BB5EF0 Offset: 0x1BB5FF1 VA: 0x1BB5EF0
	public float get_minDistance() { }

	// RVA: 0x1BB5F40 Offset: 0x1BB6041 VA: 0x1BB5F40
	public void set_minDistance(float value) { }

	// RVA: 0x1BB5F90 Offset: 0x1BB6091 VA: 0x1BB5F90
	public float get_maxDistance() { }

	// RVA: 0x1BB5FE0 Offset: 0x1BB60E1 VA: 0x1BB5FE0
	public void set_maxDistance(float value) { }

	// RVA: 0x1BB6030 Offset: 0x1BB6131 VA: 0x1BB6030
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x1BB6080 Offset: 0x1BB6181 VA: 0x1BB6080
	public void set_rolloffMode(AudioRolloffMode value) { }

	[ObsoleteAttribute] // RVA: 0xF1B40 Offset: 0xF1C41 VA: 0xF1B40
	// RVA: 0x1BB60D0 Offset: 0x1BB61D1 VA: 0x1BB60D0
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1BB6170 Offset: 0x1BB6271 VA: 0x1BB6170
	public void GetOutputData(float[] samples, int channel) { }

	[ObsoleteAttribute] // RVA: 0xF1B80 Offset: 0xF1C81 VA: 0xF1B80
	// RVA: 0x1BB61D0 Offset: 0x1BB62D1 VA: 0x1BB61D0
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1BB6280 Offset: 0x1BB6381 VA: 0x1BB6280
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB62F0 Offset: 0x1BB63F1 VA: 0x1BB62F0
	public float get_minVolume() { }

	// RVA: 0x1BB6370 Offset: 0x1BB6471 VA: 0x1BB6370
	public void set_minVolume(float value) { }

	// RVA: 0x1BB63E0 Offset: 0x1BB64E1 VA: 0x1BB63E0
	public float get_maxVolume() { }

	// RVA: 0x1BB6460 Offset: 0x1BB6561 VA: 0x1BB6460
	public void set_maxVolume(float value) { }

	// RVA: 0x1BB64D0 Offset: 0x1BB65D1 VA: 0x1BB64D0
	public float get_rolloffFactor() { }

	// RVA: 0x1BB6550 Offset: 0x1BB6651 VA: 0x1BB6550
	public void set_rolloffFactor(float value) { }

	// RVA: 0x1BB65C0 Offset: 0x1BB66C1 VA: 0x1BB65C0
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x1BB6620 Offset: 0x1BB6721 VA: 0x1BB6620
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x1BB6680 Offset: 0x1BB6781 VA: 0x1BB6680
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x1BB66E0 Offset: 0x1BB67E1 VA: 0x1BB66E0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x1BB6740 Offset: 0x1BB6841 VA: 0x1BB6740
	public void .ctor() { }
}

[StaticAccessorAttribute] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
[RequireComponent] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 3568
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2090 Offset: 0xF2191 VA: 0xF2090
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xF20D0 Offset: 0xF21D1 VA: 0xF20D0
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2110 Offset: 0xF2211 VA: 0xF2110
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2150 Offset: 0xF2251 VA: 0xF2150
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2190 Offset: 0xF2291 VA: 0xF2190
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[ObsoleteAttribute] // RVA: 0xF21D0 Offset: 0xF22D1 VA: 0xF21D0
	public float minVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2210 Offset: 0xF2311 VA: 0xF2210
	public float maxVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2250 Offset: 0xF2351 VA: 0xF2250
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x1BB4550 Offset: 0x1BB4651 VA: 0x1BB4550
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1BB45A0 Offset: 0x1BB46A1 VA: 0x1BB45A0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1BB45F0 Offset: 0x1BB46F1 VA: 0x1BB45F0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x1BB4640 Offset: 0x1BB4741 VA: 0x1BB4640
	private void Play(double delay) { }

	// RVA: 0x1BB4690 Offset: 0x1BB4791 VA: 0x1BB4690
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB46F0 Offset: 0x1BB47F1 VA: 0x1BB46F0
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0xF19F0 Offset: 0xF1AF1 VA: 0xF19F0
	// RVA: 0x1BB4740 Offset: 0x1BB4841 VA: 0x1BB4740
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB47A0 Offset: 0x1BB48A1 VA: 0x1BB47A0
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x1BB47F0 Offset: 0x1BB48F1 VA: 0x1BB47F0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0xF1A00 Offset: 0xF1B01 VA: 0xF1A00
	// RVA: 0x1BB4850 Offset: 0x1BB4951 VA: 0x1BB4850
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB48C0 Offset: 0x1BB49C1 VA: 0x1BB48C0
	public float get_volume() { }

	// RVA: 0x1BB4910 Offset: 0x1BB4A11 VA: 0x1BB4910
	public void set_volume(float value) { }

	// RVA: 0x1BB4960 Offset: 0x1BB4A61 VA: 0x1BB4960
	public float get_pitch() { }

	// RVA: 0x1BB49B0 Offset: 0x1BB4AB1 VA: 0x1BB49B0
	public void set_pitch(float value) { }

	// RVA: 0x1BB4A00 Offset: 0x1BB4B01 VA: 0x1BB4A00
	public float get_time() { }

	// RVA: 0x1BB4A50 Offset: 0x1BB4B51 VA: 0x1BB4A50
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0xF1A10 Offset: 0xF1B11 VA: 0xF1A10
	// RVA: 0x1BB4AA0 Offset: 0x1BB4BA1 VA: 0x1BB4AA0
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0xF1A50 Offset: 0xF1B51 VA: 0xF1A50
	// RVA: 0x1BB4AF0 Offset: 0x1BB4BF1 VA: 0x1BB4AF0
	public void set_timeSamples(int value) { }

	// RVA: 0x1BB4B40 Offset: 0x1BB4C41 VA: 0x1BB4B40
	public AudioClip get_clip() { }

	// RVA: 0x1BB4B90 Offset: 0x1BB4C91 VA: 0x1BB4B90
	public void set_clip(AudioClip value) { }

	// RVA: 0x1BB4BE0 Offset: 0x1BB4CE1 VA: 0x1BB4BE0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1BB4C30 Offset: 0x1BB4D31 VA: 0x1BB4C30
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1A90 Offset: 0xF1B91 VA: 0xF1A90
	// RVA: 0x1BB4C80 Offset: 0x1BB4D81 VA: 0x1BB4C80
	public void Play() { }

	// RVA: 0x1BB4CD0 Offset: 0x1BB4DD1 VA: 0x1BB4CD0
	public void Play(ulong delay) { }

	// RVA: 0x1BB4D20 Offset: 0x1BB4E21 VA: 0x1BB4D20
	public void PlayDelayed(float delay) { }

	// RVA: 0x1BB4D90 Offset: 0x1BB4E91 VA: 0x1BB4D90
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1AA0 Offset: 0xF1BA1 VA: 0xF1AA0
	// RVA: 0x1BB4DF0 Offset: 0x1BB4EF1 VA: 0x1BB4DF0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1BB4E00 Offset: 0x1BB4F01 VA: 0x1BB4E00
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB4F00 Offset: 0x1BB5001 VA: 0x1BB4F00
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x1BB4F50 Offset: 0x1BB5051 VA: 0x1BB4F50
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x1BB4FA0 Offset: 0x1BB50A1 VA: 0x1BB4FA0
	public void Stop() { }

	// RVA: 0x1BB4FF0 Offset: 0x1BB50F1 VA: 0x1BB4FF0
	public void Pause() { }

	// RVA: 0x1BB5040 Offset: 0x1BB5141 VA: 0x1BB5040
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xF1AB0 Offset: 0xF1BB1 VA: 0xF1AB0
	// RVA: 0x1BB5090 Offset: 0x1BB5191 VA: 0x1BB5090
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xF1AF0 Offset: 0xF1BF1 VA: 0xF1AF0
	// RVA: 0x1BB50E0 Offset: 0x1BB51E1 VA: 0x1BB50E0
	public bool get_isVirtual() { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1B30 Offset: 0xF1C31 VA: 0xF1B30
	// RVA: 0x1BB5130 Offset: 0x1BB5231 VA: 0x1BB5130
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x1BB5140 Offset: 0x1BB5241 VA: 0x1BB5140
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x1BB53F0 Offset: 0x1BB54F1 VA: 0x1BB53F0
	public bool get_loop() { }

	// RVA: 0x1BB5440 Offset: 0x1BB5541 VA: 0x1BB5440
	public void set_loop(bool value) { }

	// RVA: 0x1BB5490 Offset: 0x1BB5591 VA: 0x1BB5490
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x1BB54E0 Offset: 0x1BB55E1 VA: 0x1BB54E0
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x1BB5530 Offset: 0x1BB5631 VA: 0x1BB5530
	public bool get_playOnAwake() { }

	// RVA: 0x1BB5580 Offset: 0x1BB5681 VA: 0x1BB5580
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BB55D0 Offset: 0x1BB56D1 VA: 0x1BB55D0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x1BB5620 Offset: 0x1BB5721 VA: 0x1BB5620
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x1BB5670 Offset: 0x1BB5771 VA: 0x1BB5670
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1BB56C0 Offset: 0x1BB57C1 VA: 0x1BB56C0
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x1BB5710 Offset: 0x1BB5811 VA: 0x1BB5710
	public float get_panStereo() { }

	// RVA: 0x1BB5760 Offset: 0x1BB5861 VA: 0x1BB5760
	public void set_panStereo(float value) { }

	// RVA: 0x1BB57B0 Offset: 0x1BB58B1 VA: 0x1BB57B0
	public float get_spatialBlend() { }

	// RVA: 0x1BB53A0 Offset: 0x1BB54A1 VA: 0x1BB53A0
	public void set_spatialBlend(float value) { }

	// RVA: 0x1BB5800 Offset: 0x1BB5901 VA: 0x1BB5800
	public bool get_spatialize() { }

	// RVA: 0x1BB5850 Offset: 0x1BB5951 VA: 0x1BB5850
	public void set_spatialize(bool value) { }

	// RVA: 0x1BB58A0 Offset: 0x1BB59A1 VA: 0x1BB58A0
	public bool get_spatializePostEffects() { }

	// RVA: 0x1BB58F0 Offset: 0x1BB59F1 VA: 0x1BB58F0
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x1BB5940 Offset: 0x1BB5A41 VA: 0x1BB5940
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB59A0 Offset: 0x1BB5AA1 VA: 0x1BB59A0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x1BB59F0 Offset: 0x1BB5AF1 VA: 0x1BB59F0
	public float get_reverbZoneMix() { }

	// RVA: 0x1BB5A40 Offset: 0x1BB5B41 VA: 0x1BB5A40
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x1BB5A90 Offset: 0x1BB5B91 VA: 0x1BB5A90
	public bool get_bypassEffects() { }

	// RVA: 0x1BB5AE0 Offset: 0x1BB5BE1 VA: 0x1BB5AE0
	public void set_bypassEffects(bool value) { }

	// RVA: 0x1BB5B30 Offset: 0x1BB5C31 VA: 0x1BB5B30
	public bool get_bypassListenerEffects() { }

	// RVA: 0x1BB5B80 Offset: 0x1BB5C81 VA: 0x1BB5B80
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x1BB5BD0 Offset: 0x1BB5CD1 VA: 0x1BB5BD0
	public bool get_bypassReverbZones() { }

	// RVA: 0x1BB5C20 Offset: 0x1BB5D21 VA: 0x1BB5C20
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x1BB5C70 Offset: 0x1BB5D71 VA: 0x1BB5C70
	public float get_dopplerLevel() { }

	// RVA: 0x1BB5CC0 Offset: 0x1BB5DC1 VA: 0x1BB5CC0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x1BB5D10 Offset: 0x1BB5E11 VA: 0x1BB5D10
	public float get_spread() { }

	// RVA: 0x1BB5D60 Offset: 0x1BB5E61 VA: 0x1BB5D60
	public void set_spread(float value) { }

	// RVA: 0x1BB5DB0 Offset: 0x1BB5EB1 VA: 0x1BB5DB0
	public int get_priority() { }

	// RVA: 0x1BB5E00 Offset: 0x1BB5F01 VA: 0x1BB5E00
	public void set_priority(int value) { }

	// RVA: 0x1BB5E50 Offset: 0x1BB5F51 VA: 0x1BB5E50
	public bool get_mute() { }

	// RVA: 0x1BB5EA0 Offset: 0x1BB5FA1 VA: 0x1BB5EA0
	public void set_mute(bool value) { }

	// RVA: 0x1BB5EF0 Offset: 0x1BB5FF1 VA: 0x1BB5EF0
	public float get_minDistance() { }

	// RVA: 0x1BB5F40 Offset: 0x1BB6041 VA: 0x1BB5F40
	public void set_minDistance(float value) { }

	// RVA: 0x1BB5F90 Offset: 0x1BB6091 VA: 0x1BB5F90
	public float get_maxDistance() { }

	// RVA: 0x1BB5FE0 Offset: 0x1BB60E1 VA: 0x1BB5FE0
	public void set_maxDistance(float value) { }

	// RVA: 0x1BB6030 Offset: 0x1BB6131 VA: 0x1BB6030
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x1BB6080 Offset: 0x1BB6181 VA: 0x1BB6080
	public void set_rolloffMode(AudioRolloffMode value) { }

	[ObsoleteAttribute] // RVA: 0xF1B40 Offset: 0xF1C41 VA: 0xF1B40
	// RVA: 0x1BB60D0 Offset: 0x1BB61D1 VA: 0x1BB60D0
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1BB6170 Offset: 0x1BB6271 VA: 0x1BB6170
	public void GetOutputData(float[] samples, int channel) { }

	[ObsoleteAttribute] // RVA: 0xF1B80 Offset: 0xF1C81 VA: 0xF1B80
	// RVA: 0x1BB61D0 Offset: 0x1BB62D1 VA: 0x1BB61D0
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1BB6280 Offset: 0x1BB6381 VA: 0x1BB6280
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB62F0 Offset: 0x1BB63F1 VA: 0x1BB62F0
	public float get_minVolume() { }

	// RVA: 0x1BB6370 Offset: 0x1BB6471 VA: 0x1BB6370
	public void set_minVolume(float value) { }

	// RVA: 0x1BB63E0 Offset: 0x1BB64E1 VA: 0x1BB63E0
	public float get_maxVolume() { }

	// RVA: 0x1BB6460 Offset: 0x1BB6561 VA: 0x1BB6460
	public void set_maxVolume(float value) { }

	// RVA: 0x1BB64D0 Offset: 0x1BB65D1 VA: 0x1BB64D0
	public float get_rolloffFactor() { }

	// RVA: 0x1BB6550 Offset: 0x1BB6651 VA: 0x1BB6550
	public void set_rolloffFactor(float value) { }

	// RVA: 0x1BB65C0 Offset: 0x1BB66C1 VA: 0x1BB65C0
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x1BB6620 Offset: 0x1BB6721 VA: 0x1BB6620
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x1BB6680 Offset: 0x1BB6781 VA: 0x1BB6680
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x1BB66E0 Offset: 0x1BB67E1 VA: 0x1BB66E0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x1BB6740 Offset: 0x1BB6841 VA: 0x1BB6740
	public void .ctor() { }
}

[StaticAccessorAttribute] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
[RequireComponent] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 3568
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2090 Offset: 0xF2191 VA: 0xF2090
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xF20D0 Offset: 0xF21D1 VA: 0xF20D0
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2110 Offset: 0xF2211 VA: 0xF2110
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2150 Offset: 0xF2251 VA: 0xF2150
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2190 Offset: 0xF2291 VA: 0xF2190
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[ObsoleteAttribute] // RVA: 0xF21D0 Offset: 0xF22D1 VA: 0xF21D0
	public float minVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2210 Offset: 0xF2311 VA: 0xF2210
	public float maxVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2250 Offset: 0xF2351 VA: 0xF2250
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x1BB4550 Offset: 0x1BB4651 VA: 0x1BB4550
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1BB45A0 Offset: 0x1BB46A1 VA: 0x1BB45A0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1BB45F0 Offset: 0x1BB46F1 VA: 0x1BB45F0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x1BB4640 Offset: 0x1BB4741 VA: 0x1BB4640
	private void Play(double delay) { }

	// RVA: 0x1BB4690 Offset: 0x1BB4791 VA: 0x1BB4690
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB46F0 Offset: 0x1BB47F1 VA: 0x1BB46F0
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0xF19F0 Offset: 0xF1AF1 VA: 0xF19F0
	// RVA: 0x1BB4740 Offset: 0x1BB4841 VA: 0x1BB4740
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB47A0 Offset: 0x1BB48A1 VA: 0x1BB47A0
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x1BB47F0 Offset: 0x1BB48F1 VA: 0x1BB47F0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0xF1A00 Offset: 0xF1B01 VA: 0xF1A00
	// RVA: 0x1BB4850 Offset: 0x1BB4951 VA: 0x1BB4850
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB48C0 Offset: 0x1BB49C1 VA: 0x1BB48C0
	public float get_volume() { }

	// RVA: 0x1BB4910 Offset: 0x1BB4A11 VA: 0x1BB4910
	public void set_volume(float value) { }

	// RVA: 0x1BB4960 Offset: 0x1BB4A61 VA: 0x1BB4960
	public float get_pitch() { }

	// RVA: 0x1BB49B0 Offset: 0x1BB4AB1 VA: 0x1BB49B0
	public void set_pitch(float value) { }

	// RVA: 0x1BB4A00 Offset: 0x1BB4B01 VA: 0x1BB4A00
	public float get_time() { }

	// RVA: 0x1BB4A50 Offset: 0x1BB4B51 VA: 0x1BB4A50
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0xF1A10 Offset: 0xF1B11 VA: 0xF1A10
	// RVA: 0x1BB4AA0 Offset: 0x1BB4BA1 VA: 0x1BB4AA0
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0xF1A50 Offset: 0xF1B51 VA: 0xF1A50
	// RVA: 0x1BB4AF0 Offset: 0x1BB4BF1 VA: 0x1BB4AF0
	public void set_timeSamples(int value) { }

	// RVA: 0x1BB4B40 Offset: 0x1BB4C41 VA: 0x1BB4B40
	public AudioClip get_clip() { }

	// RVA: 0x1BB4B90 Offset: 0x1BB4C91 VA: 0x1BB4B90
	public void set_clip(AudioClip value) { }

	// RVA: 0x1BB4BE0 Offset: 0x1BB4CE1 VA: 0x1BB4BE0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1BB4C30 Offset: 0x1BB4D31 VA: 0x1BB4C30
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1A90 Offset: 0xF1B91 VA: 0xF1A90
	// RVA: 0x1BB4C80 Offset: 0x1BB4D81 VA: 0x1BB4C80
	public void Play() { }

	// RVA: 0x1BB4CD0 Offset: 0x1BB4DD1 VA: 0x1BB4CD0
	public void Play(ulong delay) { }

	// RVA: 0x1BB4D20 Offset: 0x1BB4E21 VA: 0x1BB4D20
	public void PlayDelayed(float delay) { }

	// RVA: 0x1BB4D90 Offset: 0x1BB4E91 VA: 0x1BB4D90
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1AA0 Offset: 0xF1BA1 VA: 0xF1AA0
	// RVA: 0x1BB4DF0 Offset: 0x1BB4EF1 VA: 0x1BB4DF0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1BB4E00 Offset: 0x1BB4F01 VA: 0x1BB4E00
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB4F00 Offset: 0x1BB5001 VA: 0x1BB4F00
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x1BB4F50 Offset: 0x1BB5051 VA: 0x1BB4F50
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x1BB4FA0 Offset: 0x1BB50A1 VA: 0x1BB4FA0
	public void Stop() { }

	// RVA: 0x1BB4FF0 Offset: 0x1BB50F1 VA: 0x1BB4FF0
	public void Pause() { }

	// RVA: 0x1BB5040 Offset: 0x1BB5141 VA: 0x1BB5040
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xF1AB0 Offset: 0xF1BB1 VA: 0xF1AB0
	// RVA: 0x1BB5090 Offset: 0x1BB5191 VA: 0x1BB5090
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xF1AF0 Offset: 0xF1BF1 VA: 0xF1AF0
	// RVA: 0x1BB50E0 Offset: 0x1BB51E1 VA: 0x1BB50E0
	public bool get_isVirtual() { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1B30 Offset: 0xF1C31 VA: 0xF1B30
	// RVA: 0x1BB5130 Offset: 0x1BB5231 VA: 0x1BB5130
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x1BB5140 Offset: 0x1BB5241 VA: 0x1BB5140
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x1BB53F0 Offset: 0x1BB54F1 VA: 0x1BB53F0
	public bool get_loop() { }

	// RVA: 0x1BB5440 Offset: 0x1BB5541 VA: 0x1BB5440
	public void set_loop(bool value) { }

	// RVA: 0x1BB5490 Offset: 0x1BB5591 VA: 0x1BB5490
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x1BB54E0 Offset: 0x1BB55E1 VA: 0x1BB54E0
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x1BB5530 Offset: 0x1BB5631 VA: 0x1BB5530
	public bool get_playOnAwake() { }

	// RVA: 0x1BB5580 Offset: 0x1BB5681 VA: 0x1BB5580
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BB55D0 Offset: 0x1BB56D1 VA: 0x1BB55D0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x1BB5620 Offset: 0x1BB5721 VA: 0x1BB5620
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x1BB5670 Offset: 0x1BB5771 VA: 0x1BB5670
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1BB56C0 Offset: 0x1BB57C1 VA: 0x1BB56C0
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x1BB5710 Offset: 0x1BB5811 VA: 0x1BB5710
	public float get_panStereo() { }

	// RVA: 0x1BB5760 Offset: 0x1BB5861 VA: 0x1BB5760
	public void set_panStereo(float value) { }

	// RVA: 0x1BB57B0 Offset: 0x1BB58B1 VA: 0x1BB57B0
	public float get_spatialBlend() { }

	// RVA: 0x1BB53A0 Offset: 0x1BB54A1 VA: 0x1BB53A0
	public void set_spatialBlend(float value) { }

	// RVA: 0x1BB5800 Offset: 0x1BB5901 VA: 0x1BB5800
	public bool get_spatialize() { }

	// RVA: 0x1BB5850 Offset: 0x1BB5951 VA: 0x1BB5850
	public void set_spatialize(bool value) { }

	// RVA: 0x1BB58A0 Offset: 0x1BB59A1 VA: 0x1BB58A0
	public bool get_spatializePostEffects() { }

	// RVA: 0x1BB58F0 Offset: 0x1BB59F1 VA: 0x1BB58F0
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x1BB5940 Offset: 0x1BB5A41 VA: 0x1BB5940
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB59A0 Offset: 0x1BB5AA1 VA: 0x1BB59A0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x1BB59F0 Offset: 0x1BB5AF1 VA: 0x1BB59F0
	public float get_reverbZoneMix() { }

	// RVA: 0x1BB5A40 Offset: 0x1BB5B41 VA: 0x1BB5A40
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x1BB5A90 Offset: 0x1BB5B91 VA: 0x1BB5A90
	public bool get_bypassEffects() { }

	// RVA: 0x1BB5AE0 Offset: 0x1BB5BE1 VA: 0x1BB5AE0
	public void set_bypassEffects(bool value) { }

	// RVA: 0x1BB5B30 Offset: 0x1BB5C31 VA: 0x1BB5B30
	public bool get_bypassListenerEffects() { }

	// RVA: 0x1BB5B80 Offset: 0x1BB5C81 VA: 0x1BB5B80
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x1BB5BD0 Offset: 0x1BB5CD1 VA: 0x1BB5BD0
	public bool get_bypassReverbZones() { }

	// RVA: 0x1BB5C20 Offset: 0x1BB5D21 VA: 0x1BB5C20
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x1BB5C70 Offset: 0x1BB5D71 VA: 0x1BB5C70
	public float get_dopplerLevel() { }

	// RVA: 0x1BB5CC0 Offset: 0x1BB5DC1 VA: 0x1BB5CC0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x1BB5D10 Offset: 0x1BB5E11 VA: 0x1BB5D10
	public float get_spread() { }

	// RVA: 0x1BB5D60 Offset: 0x1BB5E61 VA: 0x1BB5D60
	public void set_spread(float value) { }

	// RVA: 0x1BB5DB0 Offset: 0x1BB5EB1 VA: 0x1BB5DB0
	public int get_priority() { }

	// RVA: 0x1BB5E00 Offset: 0x1BB5F01 VA: 0x1BB5E00
	public void set_priority(int value) { }

	// RVA: 0x1BB5E50 Offset: 0x1BB5F51 VA: 0x1BB5E50
	public bool get_mute() { }

	// RVA: 0x1BB5EA0 Offset: 0x1BB5FA1 VA: 0x1BB5EA0
	public void set_mute(bool value) { }

	// RVA: 0x1BB5EF0 Offset: 0x1BB5FF1 VA: 0x1BB5EF0
	public float get_minDistance() { }

	// RVA: 0x1BB5F40 Offset: 0x1BB6041 VA: 0x1BB5F40
	public void set_minDistance(float value) { }

	// RVA: 0x1BB5F90 Offset: 0x1BB6091 VA: 0x1BB5F90
	public float get_maxDistance() { }

	// RVA: 0x1BB5FE0 Offset: 0x1BB60E1 VA: 0x1BB5FE0
	public void set_maxDistance(float value) { }

	// RVA: 0x1BB6030 Offset: 0x1BB6131 VA: 0x1BB6030
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x1BB6080 Offset: 0x1BB6181 VA: 0x1BB6080
	public void set_rolloffMode(AudioRolloffMode value) { }

	[ObsoleteAttribute] // RVA: 0xF1B40 Offset: 0xF1C41 VA: 0xF1B40
	// RVA: 0x1BB60D0 Offset: 0x1BB61D1 VA: 0x1BB60D0
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1BB6170 Offset: 0x1BB6271 VA: 0x1BB6170
	public void GetOutputData(float[] samples, int channel) { }

	[ObsoleteAttribute] // RVA: 0xF1B80 Offset: 0xF1C81 VA: 0xF1B80
	// RVA: 0x1BB61D0 Offset: 0x1BB62D1 VA: 0x1BB61D0
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1BB6280 Offset: 0x1BB6381 VA: 0x1BB6280
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB62F0 Offset: 0x1BB63F1 VA: 0x1BB62F0
	public float get_minVolume() { }

	// RVA: 0x1BB6370 Offset: 0x1BB6471 VA: 0x1BB6370
	public void set_minVolume(float value) { }

	// RVA: 0x1BB63E0 Offset: 0x1BB64E1 VA: 0x1BB63E0
	public float get_maxVolume() { }

	// RVA: 0x1BB6460 Offset: 0x1BB6561 VA: 0x1BB6460
	public void set_maxVolume(float value) { }

	// RVA: 0x1BB64D0 Offset: 0x1BB65D1 VA: 0x1BB64D0
	public float get_rolloffFactor() { }

	// RVA: 0x1BB6550 Offset: 0x1BB6651 VA: 0x1BB6550
	public void set_rolloffFactor(float value) { }

	// RVA: 0x1BB65C0 Offset: 0x1BB66C1 VA: 0x1BB65C0
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x1BB6620 Offset: 0x1BB6721 VA: 0x1BB6620
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x1BB6680 Offset: 0x1BB6781 VA: 0x1BB6680
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x1BB66E0 Offset: 0x1BB67E1 VA: 0x1BB66E0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x1BB6740 Offset: 0x1BB6841 VA: 0x1BB6740
	public void .ctor() { }
}

[StaticAccessorAttribute] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
[RequireComponent] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 3568
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2090 Offset: 0xF2191 VA: 0xF2090
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xF20D0 Offset: 0xF21D1 VA: 0xF20D0
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2110 Offset: 0xF2211 VA: 0xF2110
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2150 Offset: 0xF2251 VA: 0xF2150
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2190 Offset: 0xF2291 VA: 0xF2190
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[ObsoleteAttribute] // RVA: 0xF21D0 Offset: 0xF22D1 VA: 0xF21D0
	public float minVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2210 Offset: 0xF2311 VA: 0xF2210
	public float maxVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2250 Offset: 0xF2351 VA: 0xF2250
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x1BB4550 Offset: 0x1BB4651 VA: 0x1BB4550
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1BB45A0 Offset: 0x1BB46A1 VA: 0x1BB45A0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1BB45F0 Offset: 0x1BB46F1 VA: 0x1BB45F0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x1BB4640 Offset: 0x1BB4741 VA: 0x1BB4640
	private void Play(double delay) { }

	// RVA: 0x1BB4690 Offset: 0x1BB4791 VA: 0x1BB4690
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB46F0 Offset: 0x1BB47F1 VA: 0x1BB46F0
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0xF19F0 Offset: 0xF1AF1 VA: 0xF19F0
	// RVA: 0x1BB4740 Offset: 0x1BB4841 VA: 0x1BB4740
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB47A0 Offset: 0x1BB48A1 VA: 0x1BB47A0
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x1BB47F0 Offset: 0x1BB48F1 VA: 0x1BB47F0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0xF1A00 Offset: 0xF1B01 VA: 0xF1A00
	// RVA: 0x1BB4850 Offset: 0x1BB4951 VA: 0x1BB4850
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB48C0 Offset: 0x1BB49C1 VA: 0x1BB48C0
	public float get_volume() { }

	// RVA: 0x1BB4910 Offset: 0x1BB4A11 VA: 0x1BB4910
	public void set_volume(float value) { }

	// RVA: 0x1BB4960 Offset: 0x1BB4A61 VA: 0x1BB4960
	public float get_pitch() { }

	// RVA: 0x1BB49B0 Offset: 0x1BB4AB1 VA: 0x1BB49B0
	public void set_pitch(float value) { }

	// RVA: 0x1BB4A00 Offset: 0x1BB4B01 VA: 0x1BB4A00
	public float get_time() { }

	// RVA: 0x1BB4A50 Offset: 0x1BB4B51 VA: 0x1BB4A50
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0xF1A10 Offset: 0xF1B11 VA: 0xF1A10
	// RVA: 0x1BB4AA0 Offset: 0x1BB4BA1 VA: 0x1BB4AA0
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0xF1A50 Offset: 0xF1B51 VA: 0xF1A50
	// RVA: 0x1BB4AF0 Offset: 0x1BB4BF1 VA: 0x1BB4AF0
	public void set_timeSamples(int value) { }

	// RVA: 0x1BB4B40 Offset: 0x1BB4C41 VA: 0x1BB4B40
	public AudioClip get_clip() { }

	// RVA: 0x1BB4B90 Offset: 0x1BB4C91 VA: 0x1BB4B90
	public void set_clip(AudioClip value) { }

	// RVA: 0x1BB4BE0 Offset: 0x1BB4CE1 VA: 0x1BB4BE0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1BB4C30 Offset: 0x1BB4D31 VA: 0x1BB4C30
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1A90 Offset: 0xF1B91 VA: 0xF1A90
	// RVA: 0x1BB4C80 Offset: 0x1BB4D81 VA: 0x1BB4C80
	public void Play() { }

	// RVA: 0x1BB4CD0 Offset: 0x1BB4DD1 VA: 0x1BB4CD0
	public void Play(ulong delay) { }

	// RVA: 0x1BB4D20 Offset: 0x1BB4E21 VA: 0x1BB4D20
	public void PlayDelayed(float delay) { }

	// RVA: 0x1BB4D90 Offset: 0x1BB4E91 VA: 0x1BB4D90
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1AA0 Offset: 0xF1BA1 VA: 0xF1AA0
	// RVA: 0x1BB4DF0 Offset: 0x1BB4EF1 VA: 0x1BB4DF0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1BB4E00 Offset: 0x1BB4F01 VA: 0x1BB4E00
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB4F00 Offset: 0x1BB5001 VA: 0x1BB4F00
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x1BB4F50 Offset: 0x1BB5051 VA: 0x1BB4F50
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x1BB4FA0 Offset: 0x1BB50A1 VA: 0x1BB4FA0
	public void Stop() { }

	// RVA: 0x1BB4FF0 Offset: 0x1BB50F1 VA: 0x1BB4FF0
	public void Pause() { }

	// RVA: 0x1BB5040 Offset: 0x1BB5141 VA: 0x1BB5040
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xF1AB0 Offset: 0xF1BB1 VA: 0xF1AB0
	// RVA: 0x1BB5090 Offset: 0x1BB5191 VA: 0x1BB5090
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xF1AF0 Offset: 0xF1BF1 VA: 0xF1AF0
	// RVA: 0x1BB50E0 Offset: 0x1BB51E1 VA: 0x1BB50E0
	public bool get_isVirtual() { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1B30 Offset: 0xF1C31 VA: 0xF1B30
	// RVA: 0x1BB5130 Offset: 0x1BB5231 VA: 0x1BB5130
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x1BB5140 Offset: 0x1BB5241 VA: 0x1BB5140
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x1BB53F0 Offset: 0x1BB54F1 VA: 0x1BB53F0
	public bool get_loop() { }

	// RVA: 0x1BB5440 Offset: 0x1BB5541 VA: 0x1BB5440
	public void set_loop(bool value) { }

	// RVA: 0x1BB5490 Offset: 0x1BB5591 VA: 0x1BB5490
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x1BB54E0 Offset: 0x1BB55E1 VA: 0x1BB54E0
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x1BB5530 Offset: 0x1BB5631 VA: 0x1BB5530
	public bool get_playOnAwake() { }

	// RVA: 0x1BB5580 Offset: 0x1BB5681 VA: 0x1BB5580
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BB55D0 Offset: 0x1BB56D1 VA: 0x1BB55D0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x1BB5620 Offset: 0x1BB5721 VA: 0x1BB5620
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x1BB5670 Offset: 0x1BB5771 VA: 0x1BB5670
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1BB56C0 Offset: 0x1BB57C1 VA: 0x1BB56C0
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x1BB5710 Offset: 0x1BB5811 VA: 0x1BB5710
	public float get_panStereo() { }

	// RVA: 0x1BB5760 Offset: 0x1BB5861 VA: 0x1BB5760
	public void set_panStereo(float value) { }

	// RVA: 0x1BB57B0 Offset: 0x1BB58B1 VA: 0x1BB57B0
	public float get_spatialBlend() { }

	// RVA: 0x1BB53A0 Offset: 0x1BB54A1 VA: 0x1BB53A0
	public void set_spatialBlend(float value) { }

	// RVA: 0x1BB5800 Offset: 0x1BB5901 VA: 0x1BB5800
	public bool get_spatialize() { }

	// RVA: 0x1BB5850 Offset: 0x1BB5951 VA: 0x1BB5850
	public void set_spatialize(bool value) { }

	// RVA: 0x1BB58A0 Offset: 0x1BB59A1 VA: 0x1BB58A0
	public bool get_spatializePostEffects() { }

	// RVA: 0x1BB58F0 Offset: 0x1BB59F1 VA: 0x1BB58F0
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x1BB5940 Offset: 0x1BB5A41 VA: 0x1BB5940
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB59A0 Offset: 0x1BB5AA1 VA: 0x1BB59A0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x1BB59F0 Offset: 0x1BB5AF1 VA: 0x1BB59F0
	public float get_reverbZoneMix() { }

	// RVA: 0x1BB5A40 Offset: 0x1BB5B41 VA: 0x1BB5A40
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x1BB5A90 Offset: 0x1BB5B91 VA: 0x1BB5A90
	public bool get_bypassEffects() { }

	// RVA: 0x1BB5AE0 Offset: 0x1BB5BE1 VA: 0x1BB5AE0
	public void set_bypassEffects(bool value) { }

	// RVA: 0x1BB5B30 Offset: 0x1BB5C31 VA: 0x1BB5B30
	public bool get_bypassListenerEffects() { }

	// RVA: 0x1BB5B80 Offset: 0x1BB5C81 VA: 0x1BB5B80
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x1BB5BD0 Offset: 0x1BB5CD1 VA: 0x1BB5BD0
	public bool get_bypassReverbZones() { }

	// RVA: 0x1BB5C20 Offset: 0x1BB5D21 VA: 0x1BB5C20
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x1BB5C70 Offset: 0x1BB5D71 VA: 0x1BB5C70
	public float get_dopplerLevel() { }

	// RVA: 0x1BB5CC0 Offset: 0x1BB5DC1 VA: 0x1BB5CC0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x1BB5D10 Offset: 0x1BB5E11 VA: 0x1BB5D10
	public float get_spread() { }

	// RVA: 0x1BB5D60 Offset: 0x1BB5E61 VA: 0x1BB5D60
	public void set_spread(float value) { }

	// RVA: 0x1BB5DB0 Offset: 0x1BB5EB1 VA: 0x1BB5DB0
	public int get_priority() { }

	// RVA: 0x1BB5E00 Offset: 0x1BB5F01 VA: 0x1BB5E00
	public void set_priority(int value) { }

	// RVA: 0x1BB5E50 Offset: 0x1BB5F51 VA: 0x1BB5E50
	public bool get_mute() { }

	// RVA: 0x1BB5EA0 Offset: 0x1BB5FA1 VA: 0x1BB5EA0
	public void set_mute(bool value) { }

	// RVA: 0x1BB5EF0 Offset: 0x1BB5FF1 VA: 0x1BB5EF0
	public float get_minDistance() { }

	// RVA: 0x1BB5F40 Offset: 0x1BB6041 VA: 0x1BB5F40
	public void set_minDistance(float value) { }

	// RVA: 0x1BB5F90 Offset: 0x1BB6091 VA: 0x1BB5F90
	public float get_maxDistance() { }

	// RVA: 0x1BB5FE0 Offset: 0x1BB60E1 VA: 0x1BB5FE0
	public void set_maxDistance(float value) { }

	// RVA: 0x1BB6030 Offset: 0x1BB6131 VA: 0x1BB6030
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x1BB6080 Offset: 0x1BB6181 VA: 0x1BB6080
	public void set_rolloffMode(AudioRolloffMode value) { }

	[ObsoleteAttribute] // RVA: 0xF1B40 Offset: 0xF1C41 VA: 0xF1B40
	// RVA: 0x1BB60D0 Offset: 0x1BB61D1 VA: 0x1BB60D0
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1BB6170 Offset: 0x1BB6271 VA: 0x1BB6170
	public void GetOutputData(float[] samples, int channel) { }

	[ObsoleteAttribute] // RVA: 0xF1B80 Offset: 0xF1C81 VA: 0xF1B80
	// RVA: 0x1BB61D0 Offset: 0x1BB62D1 VA: 0x1BB61D0
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1BB6280 Offset: 0x1BB6381 VA: 0x1BB6280
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB62F0 Offset: 0x1BB63F1 VA: 0x1BB62F0
	public float get_minVolume() { }

	// RVA: 0x1BB6370 Offset: 0x1BB6471 VA: 0x1BB6370
	public void set_minVolume(float value) { }

	// RVA: 0x1BB63E0 Offset: 0x1BB64E1 VA: 0x1BB63E0
	public float get_maxVolume() { }

	// RVA: 0x1BB6460 Offset: 0x1BB6561 VA: 0x1BB6460
	public void set_maxVolume(float value) { }

	// RVA: 0x1BB64D0 Offset: 0x1BB65D1 VA: 0x1BB64D0
	public float get_rolloffFactor() { }

	// RVA: 0x1BB6550 Offset: 0x1BB6651 VA: 0x1BB6550
	public void set_rolloffFactor(float value) { }

	// RVA: 0x1BB65C0 Offset: 0x1BB66C1 VA: 0x1BB65C0
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x1BB6620 Offset: 0x1BB6721 VA: 0x1BB6620
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x1BB6680 Offset: 0x1BB6781 VA: 0x1BB6680
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x1BB66E0 Offset: 0x1BB67E1 VA: 0x1BB66E0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x1BB6740 Offset: 0x1BB6841 VA: 0x1BB6740
	public void .ctor() { }
}

[StaticAccessorAttribute] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
[RequireComponent] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 3568
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2090 Offset: 0xF2191 VA: 0xF2090
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xF20D0 Offset: 0xF21D1 VA: 0xF20D0
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2110 Offset: 0xF2211 VA: 0xF2110
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2150 Offset: 0xF2251 VA: 0xF2150
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2190 Offset: 0xF2291 VA: 0xF2190
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[ObsoleteAttribute] // RVA: 0xF21D0 Offset: 0xF22D1 VA: 0xF21D0
	public float minVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2210 Offset: 0xF2311 VA: 0xF2210
	public float maxVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2250 Offset: 0xF2351 VA: 0xF2250
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x1BB4550 Offset: 0x1BB4651 VA: 0x1BB4550
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1BB45A0 Offset: 0x1BB46A1 VA: 0x1BB45A0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1BB45F0 Offset: 0x1BB46F1 VA: 0x1BB45F0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x1BB4640 Offset: 0x1BB4741 VA: 0x1BB4640
	private void Play(double delay) { }

	// RVA: 0x1BB4690 Offset: 0x1BB4791 VA: 0x1BB4690
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB46F0 Offset: 0x1BB47F1 VA: 0x1BB46F0
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0xF19F0 Offset: 0xF1AF1 VA: 0xF19F0
	// RVA: 0x1BB4740 Offset: 0x1BB4841 VA: 0x1BB4740
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB47A0 Offset: 0x1BB48A1 VA: 0x1BB47A0
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x1BB47F0 Offset: 0x1BB48F1 VA: 0x1BB47F0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0xF1A00 Offset: 0xF1B01 VA: 0xF1A00
	// RVA: 0x1BB4850 Offset: 0x1BB4951 VA: 0x1BB4850
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB48C0 Offset: 0x1BB49C1 VA: 0x1BB48C0
	public float get_volume() { }

	// RVA: 0x1BB4910 Offset: 0x1BB4A11 VA: 0x1BB4910
	public void set_volume(float value) { }

	// RVA: 0x1BB4960 Offset: 0x1BB4A61 VA: 0x1BB4960
	public float get_pitch() { }

	// RVA: 0x1BB49B0 Offset: 0x1BB4AB1 VA: 0x1BB49B0
	public void set_pitch(float value) { }

	// RVA: 0x1BB4A00 Offset: 0x1BB4B01 VA: 0x1BB4A00
	public float get_time() { }

	// RVA: 0x1BB4A50 Offset: 0x1BB4B51 VA: 0x1BB4A50
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0xF1A10 Offset: 0xF1B11 VA: 0xF1A10
	// RVA: 0x1BB4AA0 Offset: 0x1BB4BA1 VA: 0x1BB4AA0
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0xF1A50 Offset: 0xF1B51 VA: 0xF1A50
	// RVA: 0x1BB4AF0 Offset: 0x1BB4BF1 VA: 0x1BB4AF0
	public void set_timeSamples(int value) { }

	// RVA: 0x1BB4B40 Offset: 0x1BB4C41 VA: 0x1BB4B40
	public AudioClip get_clip() { }

	// RVA: 0x1BB4B90 Offset: 0x1BB4C91 VA: 0x1BB4B90
	public void set_clip(AudioClip value) { }

	// RVA: 0x1BB4BE0 Offset: 0x1BB4CE1 VA: 0x1BB4BE0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1BB4C30 Offset: 0x1BB4D31 VA: 0x1BB4C30
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1A90 Offset: 0xF1B91 VA: 0xF1A90
	// RVA: 0x1BB4C80 Offset: 0x1BB4D81 VA: 0x1BB4C80
	public void Play() { }

	// RVA: 0x1BB4CD0 Offset: 0x1BB4DD1 VA: 0x1BB4CD0
	public void Play(ulong delay) { }

	// RVA: 0x1BB4D20 Offset: 0x1BB4E21 VA: 0x1BB4D20
	public void PlayDelayed(float delay) { }

	// RVA: 0x1BB4D90 Offset: 0x1BB4E91 VA: 0x1BB4D90
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1AA0 Offset: 0xF1BA1 VA: 0xF1AA0
	// RVA: 0x1BB4DF0 Offset: 0x1BB4EF1 VA: 0x1BB4DF0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1BB4E00 Offset: 0x1BB4F01 VA: 0x1BB4E00
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB4F00 Offset: 0x1BB5001 VA: 0x1BB4F00
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x1BB4F50 Offset: 0x1BB5051 VA: 0x1BB4F50
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x1BB4FA0 Offset: 0x1BB50A1 VA: 0x1BB4FA0
	public void Stop() { }

	// RVA: 0x1BB4FF0 Offset: 0x1BB50F1 VA: 0x1BB4FF0
	public void Pause() { }

	// RVA: 0x1BB5040 Offset: 0x1BB5141 VA: 0x1BB5040
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xF1AB0 Offset: 0xF1BB1 VA: 0xF1AB0
	// RVA: 0x1BB5090 Offset: 0x1BB5191 VA: 0x1BB5090
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xF1AF0 Offset: 0xF1BF1 VA: 0xF1AF0
	// RVA: 0x1BB50E0 Offset: 0x1BB51E1 VA: 0x1BB50E0
	public bool get_isVirtual() { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1B30 Offset: 0xF1C31 VA: 0xF1B30
	// RVA: 0x1BB5130 Offset: 0x1BB5231 VA: 0x1BB5130
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x1BB5140 Offset: 0x1BB5241 VA: 0x1BB5140
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x1BB53F0 Offset: 0x1BB54F1 VA: 0x1BB53F0
	public bool get_loop() { }

	// RVA: 0x1BB5440 Offset: 0x1BB5541 VA: 0x1BB5440
	public void set_loop(bool value) { }

	// RVA: 0x1BB5490 Offset: 0x1BB5591 VA: 0x1BB5490
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x1BB54E0 Offset: 0x1BB55E1 VA: 0x1BB54E0
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x1BB5530 Offset: 0x1BB5631 VA: 0x1BB5530
	public bool get_playOnAwake() { }

	// RVA: 0x1BB5580 Offset: 0x1BB5681 VA: 0x1BB5580
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BB55D0 Offset: 0x1BB56D1 VA: 0x1BB55D0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x1BB5620 Offset: 0x1BB5721 VA: 0x1BB5620
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x1BB5670 Offset: 0x1BB5771 VA: 0x1BB5670
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1BB56C0 Offset: 0x1BB57C1 VA: 0x1BB56C0
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x1BB5710 Offset: 0x1BB5811 VA: 0x1BB5710
	public float get_panStereo() { }

	// RVA: 0x1BB5760 Offset: 0x1BB5861 VA: 0x1BB5760
	public void set_panStereo(float value) { }

	// RVA: 0x1BB57B0 Offset: 0x1BB58B1 VA: 0x1BB57B0
	public float get_spatialBlend() { }

	// RVA: 0x1BB53A0 Offset: 0x1BB54A1 VA: 0x1BB53A0
	public void set_spatialBlend(float value) { }

	// RVA: 0x1BB5800 Offset: 0x1BB5901 VA: 0x1BB5800
	public bool get_spatialize() { }

	// RVA: 0x1BB5850 Offset: 0x1BB5951 VA: 0x1BB5850
	public void set_spatialize(bool value) { }

	// RVA: 0x1BB58A0 Offset: 0x1BB59A1 VA: 0x1BB58A0
	public bool get_spatializePostEffects() { }

	// RVA: 0x1BB58F0 Offset: 0x1BB59F1 VA: 0x1BB58F0
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x1BB5940 Offset: 0x1BB5A41 VA: 0x1BB5940
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB59A0 Offset: 0x1BB5AA1 VA: 0x1BB59A0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x1BB59F0 Offset: 0x1BB5AF1 VA: 0x1BB59F0
	public float get_reverbZoneMix() { }

	// RVA: 0x1BB5A40 Offset: 0x1BB5B41 VA: 0x1BB5A40
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x1BB5A90 Offset: 0x1BB5B91 VA: 0x1BB5A90
	public bool get_bypassEffects() { }

	// RVA: 0x1BB5AE0 Offset: 0x1BB5BE1 VA: 0x1BB5AE0
	public void set_bypassEffects(bool value) { }

	// RVA: 0x1BB5B30 Offset: 0x1BB5C31 VA: 0x1BB5B30
	public bool get_bypassListenerEffects() { }

	// RVA: 0x1BB5B80 Offset: 0x1BB5C81 VA: 0x1BB5B80
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x1BB5BD0 Offset: 0x1BB5CD1 VA: 0x1BB5BD0
	public bool get_bypassReverbZones() { }

	// RVA: 0x1BB5C20 Offset: 0x1BB5D21 VA: 0x1BB5C20
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x1BB5C70 Offset: 0x1BB5D71 VA: 0x1BB5C70
	public float get_dopplerLevel() { }

	// RVA: 0x1BB5CC0 Offset: 0x1BB5DC1 VA: 0x1BB5CC0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x1BB5D10 Offset: 0x1BB5E11 VA: 0x1BB5D10
	public float get_spread() { }

	// RVA: 0x1BB5D60 Offset: 0x1BB5E61 VA: 0x1BB5D60
	public void set_spread(float value) { }

	// RVA: 0x1BB5DB0 Offset: 0x1BB5EB1 VA: 0x1BB5DB0
	public int get_priority() { }

	// RVA: 0x1BB5E00 Offset: 0x1BB5F01 VA: 0x1BB5E00
	public void set_priority(int value) { }

	// RVA: 0x1BB5E50 Offset: 0x1BB5F51 VA: 0x1BB5E50
	public bool get_mute() { }

	// RVA: 0x1BB5EA0 Offset: 0x1BB5FA1 VA: 0x1BB5EA0
	public void set_mute(bool value) { }

	// RVA: 0x1BB5EF0 Offset: 0x1BB5FF1 VA: 0x1BB5EF0
	public float get_minDistance() { }

	// RVA: 0x1BB5F40 Offset: 0x1BB6041 VA: 0x1BB5F40
	public void set_minDistance(float value) { }

	// RVA: 0x1BB5F90 Offset: 0x1BB6091 VA: 0x1BB5F90
	public float get_maxDistance() { }

	// RVA: 0x1BB5FE0 Offset: 0x1BB60E1 VA: 0x1BB5FE0
	public void set_maxDistance(float value) { }

	// RVA: 0x1BB6030 Offset: 0x1BB6131 VA: 0x1BB6030
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x1BB6080 Offset: 0x1BB6181 VA: 0x1BB6080
	public void set_rolloffMode(AudioRolloffMode value) { }

	[ObsoleteAttribute] // RVA: 0xF1B40 Offset: 0xF1C41 VA: 0xF1B40
	// RVA: 0x1BB60D0 Offset: 0x1BB61D1 VA: 0x1BB60D0
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1BB6170 Offset: 0x1BB6271 VA: 0x1BB6170
	public void GetOutputData(float[] samples, int channel) { }

	[ObsoleteAttribute] // RVA: 0xF1B80 Offset: 0xF1C81 VA: 0xF1B80
	// RVA: 0x1BB61D0 Offset: 0x1BB62D1 VA: 0x1BB61D0
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1BB6280 Offset: 0x1BB6381 VA: 0x1BB6280
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB62F0 Offset: 0x1BB63F1 VA: 0x1BB62F0
	public float get_minVolume() { }

	// RVA: 0x1BB6370 Offset: 0x1BB6471 VA: 0x1BB6370
	public void set_minVolume(float value) { }

	// RVA: 0x1BB63E0 Offset: 0x1BB64E1 VA: 0x1BB63E0
	public float get_maxVolume() { }

	// RVA: 0x1BB6460 Offset: 0x1BB6561 VA: 0x1BB6460
	public void set_maxVolume(float value) { }

	// RVA: 0x1BB64D0 Offset: 0x1BB65D1 VA: 0x1BB64D0
	public float get_rolloffFactor() { }

	// RVA: 0x1BB6550 Offset: 0x1BB6651 VA: 0x1BB6550
	public void set_rolloffFactor(float value) { }

	// RVA: 0x1BB65C0 Offset: 0x1BB66C1 VA: 0x1BB65C0
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x1BB6620 Offset: 0x1BB6721 VA: 0x1BB6620
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x1BB6680 Offset: 0x1BB6781 VA: 0x1BB6680
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x1BB66E0 Offset: 0x1BB67E1 VA: 0x1BB66E0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x1BB6740 Offset: 0x1BB6841 VA: 0x1BB6740
	public void .ctor() { }
}

[StaticAccessorAttribute] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
[RequireComponent] // RVA: 0xF1060 Offset: 0xF1161 VA: 0xF1060
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 3568
{
	// Properties
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2090 Offset: 0xF2191 VA: 0xF2090
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xF20D0 Offset: 0xF21D1 VA: 0xF20D0
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2110 Offset: 0xF2211 VA: 0xF2110
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool isVirtual { get; }
	public bool loop { get; set; }
	public bool ignoreListenerVolume { get; set; }
	public bool playOnAwake { get; set; }
	public bool ignoreListenerPause { get; set; }
	public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2150 Offset: 0xF2251 VA: 0xF2150
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xF2190 Offset: 0xF2291 VA: 0xF2190
	public float spatialBlend { get; set; }
	public bool spatialize { get; set; }
	public bool spatializePostEffects { get; set; }
	public float reverbZoneMix { get; set; }
	public bool bypassEffects { get; set; }
	public bool bypassListenerEffects { get; set; }
	public bool bypassReverbZones { get; set; }
	public float dopplerLevel { get; set; }
	public float spread { get; set; }
	public int priority { get; set; }
	public bool mute { get; set; }
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioRolloffMode rolloffMode { get; set; }
	[ObsoleteAttribute] // RVA: 0xF21D0 Offset: 0xF22D1 VA: 0xF21D0
	public float minVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2210 Offset: 0xF2311 VA: 0xF2210
	public float maxVolume { get; set; }
	[ObsoleteAttribute] // RVA: 0xF2250 Offset: 0xF2351 VA: 0xF2250
	public float rolloffFactor { get; set; }

	// Methods

	// RVA: 0x1BB4550 Offset: 0x1BB4651 VA: 0x1BB4550
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1BB45A0 Offset: 0x1BB46A1 VA: 0x1BB45A0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1BB45F0 Offset: 0x1BB46F1 VA: 0x1BB45F0
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x1BB4640 Offset: 0x1BB4741 VA: 0x1BB4640
	private void Play(double delay) { }

	// RVA: 0x1BB4690 Offset: 0x1BB4791 VA: 0x1BB4690
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB46F0 Offset: 0x1BB47F1 VA: 0x1BB46F0
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0xF19F0 Offset: 0xF1AF1 VA: 0xF19F0
	// RVA: 0x1BB4740 Offset: 0x1BB4841 VA: 0x1BB4740
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB47A0 Offset: 0x1BB48A1 VA: 0x1BB47A0
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x1BB47F0 Offset: 0x1BB48F1 VA: 0x1BB47F0
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0xF1A00 Offset: 0xF1B01 VA: 0xF1A00
	// RVA: 0x1BB4850 Offset: 0x1BB4951 VA: 0x1BB4850
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB48C0 Offset: 0x1BB49C1 VA: 0x1BB48C0
	public float get_volume() { }

	// RVA: 0x1BB4910 Offset: 0x1BB4A11 VA: 0x1BB4910
	public void set_volume(float value) { }

	// RVA: 0x1BB4960 Offset: 0x1BB4A61 VA: 0x1BB4960
	public float get_pitch() { }

	// RVA: 0x1BB49B0 Offset: 0x1BB4AB1 VA: 0x1BB49B0
	public void set_pitch(float value) { }

	// RVA: 0x1BB4A00 Offset: 0x1BB4B01 VA: 0x1BB4A00
	public float get_time() { }

	// RVA: 0x1BB4A50 Offset: 0x1BB4B51 VA: 0x1BB4A50
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0xF1A10 Offset: 0xF1B11 VA: 0xF1A10
	// RVA: 0x1BB4AA0 Offset: 0x1BB4BA1 VA: 0x1BB4AA0
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0xF1A50 Offset: 0xF1B51 VA: 0xF1A50
	// RVA: 0x1BB4AF0 Offset: 0x1BB4BF1 VA: 0x1BB4AF0
	public void set_timeSamples(int value) { }

	// RVA: 0x1BB4B40 Offset: 0x1BB4C41 VA: 0x1BB4B40
	public AudioClip get_clip() { }

	// RVA: 0x1BB4B90 Offset: 0x1BB4C91 VA: 0x1BB4B90
	public void set_clip(AudioClip value) { }

	// RVA: 0x1BB4BE0 Offset: 0x1BB4CE1 VA: 0x1BB4BE0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1BB4C30 Offset: 0x1BB4D31 VA: 0x1BB4C30
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1A90 Offset: 0xF1B91 VA: 0xF1A90
	// RVA: 0x1BB4C80 Offset: 0x1BB4D81 VA: 0x1BB4C80
	public void Play() { }

	// RVA: 0x1BB4CD0 Offset: 0x1BB4DD1 VA: 0x1BB4CD0
	public void Play(ulong delay) { }

	// RVA: 0x1BB4D20 Offset: 0x1BB4E21 VA: 0x1BB4D20
	public void PlayDelayed(float delay) { }

	// RVA: 0x1BB4D90 Offset: 0x1BB4E91 VA: 0x1BB4D90
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1AA0 Offset: 0xF1BA1 VA: 0xF1AA0
	// RVA: 0x1BB4DF0 Offset: 0x1BB4EF1 VA: 0x1BB4DF0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1BB4E00 Offset: 0x1BB4F01 VA: 0x1BB4E00
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1BB4F00 Offset: 0x1BB5001 VA: 0x1BB4F00
	public void SetScheduledStartTime(double time) { }

	// RVA: 0x1BB4F50 Offset: 0x1BB5051 VA: 0x1BB4F50
	public void SetScheduledEndTime(double time) { }

	// RVA: 0x1BB4FA0 Offset: 0x1BB50A1 VA: 0x1BB4FA0
	public void Stop() { }

	// RVA: 0x1BB4FF0 Offset: 0x1BB50F1 VA: 0x1BB4FF0
	public void Pause() { }

	// RVA: 0x1BB5040 Offset: 0x1BB5141 VA: 0x1BB5040
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xF1AB0 Offset: 0xF1BB1 VA: 0xF1AB0
	// RVA: 0x1BB5090 Offset: 0x1BB5191 VA: 0x1BB5090
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0xF1AF0 Offset: 0xF1BF1 VA: 0xF1AF0
	// RVA: 0x1BB50E0 Offset: 0x1BB51E1 VA: 0x1BB50E0
	public bool get_isVirtual() { }

	[ExcludeFromDocsAttribute] // RVA: 0xF1B30 Offset: 0xF1C31 VA: 0xF1B30
	// RVA: 0x1BB5130 Offset: 0x1BB5231 VA: 0x1BB5130
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x1BB5140 Offset: 0x1BB5241 VA: 0x1BB5140
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x1BB53F0 Offset: 0x1BB54F1 VA: 0x1BB53F0
	public bool get_loop() { }

	// RVA: 0x1BB5440 Offset: 0x1BB5541 VA: 0x1BB5440
	public void set_loop(bool value) { }

	// RVA: 0x1BB5490 Offset: 0x1BB5591 VA: 0x1BB5490
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x1BB54E0 Offset: 0x1BB55E1 VA: 0x1BB54E0
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x1BB5530 Offset: 0x1BB5631 VA: 0x1BB5530
	public bool get_playOnAwake() { }

	// RVA: 0x1BB5580 Offset: 0x1BB5681 VA: 0x1BB5580
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BB55D0 Offset: 0x1BB56D1 VA: 0x1BB55D0
	public bool get_ignoreListenerPause() { }

	// RVA: 0x1BB5620 Offset: 0x1BB5721 VA: 0x1BB5620
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x1BB5670 Offset: 0x1BB5771 VA: 0x1BB5670
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1BB56C0 Offset: 0x1BB57C1 VA: 0x1BB56C0
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x1BB5710 Offset: 0x1BB5811 VA: 0x1BB5710
	public float get_panStereo() { }

	// RVA: 0x1BB5760 Offset: 0x1BB5861 VA: 0x1BB5760
	public void set_panStereo(float value) { }

	// RVA: 0x1BB57B0 Offset: 0x1BB58B1 VA: 0x1BB57B0
	public float get_spatialBlend() { }

	// RVA: 0x1BB53A0 Offset: 0x1BB54A1 VA: 0x1BB53A0
	public void set_spatialBlend(float value) { }

	// RVA: 0x1BB5800 Offset: 0x1BB5901 VA: 0x1BB5800
	public bool get_spatialize() { }

	// RVA: 0x1BB5850 Offset: 0x1BB5951 VA: 0x1BB5850
	public void set_spatialize(bool value) { }

	// RVA: 0x1BB58A0 Offset: 0x1BB59A1 VA: 0x1BB58A0
	public bool get_spatializePostEffects() { }

	// RVA: 0x1BB58F0 Offset: 0x1BB59F1 VA: 0x1BB58F0
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x1BB5940 Offset: 0x1BB5A41 VA: 0x1BB5940
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x1BB59A0 Offset: 0x1BB5AA1 VA: 0x1BB59A0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x1BB59F0 Offset: 0x1BB5AF1 VA: 0x1BB59F0
	public float get_reverbZoneMix() { }

	// RVA: 0x1BB5A40 Offset: 0x1BB5B41 VA: 0x1BB5A40
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x1BB5A90 Offset: 0x1BB5B91 VA: 0x1BB5A90
	public bool get_bypassEffects() { }

	// RVA: 0x1BB5AE0 Offset: 0x1BB5BE1 VA: 0x1BB5AE0
	public void set_bypassEffects(bool value) { }

	// RVA: 0x1BB5B30 Offset: 0x1BB5C31 VA: 0x1BB5B30
	public bool get_bypassListenerEffects() { }

	// RVA: 0x1BB5B80 Offset: 0x1BB5C81 VA: 0x1BB5B80
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x1BB5BD0 Offset: 0x1BB5CD1 VA: 0x1BB5BD0
	public bool get_bypassReverbZones() { }

	// RVA: 0x1BB5C20 Offset: 0x1BB5D21 VA: 0x1BB5C20
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x1BB5C70 Offset: 0x1BB5D71 VA: 0x1BB5C70
	public float get_dopplerLevel() { }

	// RVA: 0x1BB5CC0 Offset: 0x1BB5DC1 VA: 0x1BB5CC0
	public void set_dopplerLevel(float value) { }

	// RVA: 0x1BB5D10 Offset: 0x1BB5E11 VA: 0x1BB5D10
	public float get_spread() { }

	// RVA: 0x1BB5D60 Offset: 0x1BB5E61 VA: 0x1BB5D60
	public void set_spread(float value) { }

	// RVA: 0x1BB5DB0 Offset: 0x1BB5EB1 VA: 0x1BB5DB0
	public int get_priority() { }

	// RVA: 0x1BB5E00 Offset: 0x1BB5F01 VA: 0x1BB5E00
	public void set_priority(int value) { }

	// RVA: 0x1BB5E50 Offset: 0x1BB5F51 VA: 0x1BB5E50
	public bool get_mute() { }

	// RVA: 0x1BB5EA0 Offset: 0x1BB5FA1 VA: 0x1BB5EA0
	public void set_mute(bool value) { }

	// RVA: 0x1BB5EF0 Offset: 0x1BB5FF1 VA: 0x1BB5EF0
	public float get_minDistance() { }

	// RVA: 0x1BB5F40 Offset: 0x1BB6041 VA: 0x1BB5F40
	public void set_minDistance(float value) { }

	// RVA: 0x1BB5F90 Offset: 0x1BB6091 VA: 0x1BB5F90
	public float get_maxDistance() { }

	// RVA: 0x1BB5FE0 Offset: 0x1BB60E1 VA: 0x1BB5FE0
	public void set_maxDistance(float value) { }

	// RVA: 0x1BB6030 Offset: 0x1BB6131 VA: 0x1BB6030
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x1BB6080 Offset: 0x1BB6181 VA: 0x1BB6080
	public void set_rolloffMode(AudioRolloffMode value) { }

	[ObsoleteAttribute] // RVA: 0xF1B40 Offset: 0xF1C41 VA: 0xF1B40
	// RVA: 0x1BB60D0 Offset: 0x1BB61D1 VA: 0x1BB60D0
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1BB6170 Offset: 0x1BB6271 VA: 0x1BB6170
	public void GetOutputData(float[] samples, int channel) { }

	[ObsoleteAttribute] // RVA: 0xF1B80 Offset: 0xF1C81 VA: 0xF1B80
	// RVA: 0x1BB61D0 Offset: 0x1BB62D1 VA: 0x1BB61D0
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1BB6280 Offset: 0x1BB6381 VA: 0x1BB6280
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1BB62F0 Offset: 0x1BB63F1 VA: 0x1BB62F0
	public float get_minVolume() { }

	// RVA: 0x1BB6370 Offset: 0x1BB6471 VA: 0x1BB6370
	public void set_minVolume(float value) { }

	// RVA: 0x1BB63E0 Offset: 0x1BB64E1 VA: 0x1BB63E0
	public float get_maxVolume() { }

	// RVA: 0x1BB6460 Offset: 0x1BB6561 VA: 0x1BB6460
	public void set_maxVolume(float value) { }

	// RVA: 0x1BB64D0 Offset: 0x1BB65D1 VA: 0x1BB64D0
	public float get_rolloffFactor() { }

	// RVA: 0x1BB6550 Offset: 0x1BB6651 VA: 0x1BB6550
	public void set_rolloffFactor(float value) { }

	// RVA: 0x1BB65C0 Offset: 0x1BB66C1 VA: 0x1BB65C0
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x1BB6620 Offset: 0x1BB6721 VA: 0x1BB6620
	public bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x1BB6680 Offset: 0x1BB6781 VA: 0x1BB6680
	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x1BB66E0 Offset: 0x1BB67E1 VA: 0x1BB66E0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x1BB6740 Offset: 0x1BB6841 VA: 0x1BB6740
	public void .ctor() { }
}

