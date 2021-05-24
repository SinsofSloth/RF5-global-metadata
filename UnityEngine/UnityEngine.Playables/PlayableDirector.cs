[RequiredByNativeCodeAttribute] // RVA: 0x10CE50 Offset: 0x10CF51 VA: 0x10CE50
[NativeHeaderAttribute] // RVA: 0x10CE50 Offset: 0x10CF51 VA: 0x10CE50
[NativeHeaderAttribute] // RVA: 0x10CE50 Offset: 0x10CF51 VA: 0x10CE50
public class PlayableDirector : Behaviour, IExposedPropertyTable // TypeDefIndex: 3804
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x10CEC0 Offset: 0x10CFC1 VA: 0x10CEC0
	[CompilerGeneratedAttribute] // RVA: 0x10CEC0 Offset: 0x10CFC1 VA: 0x10CEC0
	private Action<PlayableDirector> played; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x10CF00 Offset: 0x10D001 VA: 0x10CF00
	[CompilerGeneratedAttribute] // RVA: 0x10CF00 Offset: 0x10D001 VA: 0x10CF00
	private Action<PlayableDirector> paused; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x10CF40 Offset: 0x10D041 VA: 0x10CF40
	[CompilerGeneratedAttribute] // RVA: 0x10CF40 Offset: 0x10D041 VA: 0x10CF40
	private Action<PlayableDirector> stopped; // 0x28

	// Properties
	public PlayState state { get; }
	public DirectorWrapMode extrapolationMode { get; set; }
	public PlayableAsset playableAsset { get; set; }
	public PlayableGraph playableGraph { get; }
	public bool playOnAwake { get; set; }
	public DirectorUpdateMode timeUpdateMode { get; set; }
	public double time { get; set; }
	public double initialTime { get; set; }
	public double duration { get; }

	// Methods

	// RVA: 0x1BDE660 Offset: 0x1BDE761 VA: 0x1BDE660
	public PlayState get_state() { }

	// RVA: 0x1BDE700 Offset: 0x1BDE801 VA: 0x1BDE700
	public void set_extrapolationMode(DirectorWrapMode value) { }

	// RVA: 0x1BDE7A0 Offset: 0x1BDE8A1 VA: 0x1BDE7A0
	public DirectorWrapMode get_extrapolationMode() { }

	// RVA: 0x1BDE840 Offset: 0x1BDE941 VA: 0x1BDE840
	public PlayableAsset get_playableAsset() { }

	// RVA: 0x1BDE970 Offset: 0x1BDEA71 VA: 0x1BDE970
	public void set_playableAsset(PlayableAsset value) { }

	// RVA: 0x1BDEA10 Offset: 0x1BDEB11 VA: 0x1BDEA10
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x1BDEAD0 Offset: 0x1BDEBD1 VA: 0x1BDEAD0
	public bool get_playOnAwake() { }

	// RVA: 0x1BDEB70 Offset: 0x1BDEC71 VA: 0x1BDEB70
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1BDEC10 Offset: 0x1BDED11 VA: 0x1BDEC10
	public void DeferredEvaluate() { }

	// RVA: 0x1BDECB0 Offset: 0x1BDEDB1 VA: 0x1BDECB0
	public void Play(PlayableAsset asset) { }

	// RVA: 0x1BDEDA0 Offset: 0x1BDEEA1 VA: 0x1BDEDA0
	public void Play(PlayableAsset asset, DirectorWrapMode mode) { }

	// RVA: 0x1BDEF30 Offset: 0x1BDF031 VA: 0x1BDEF30
	public void SetGenericBinding(Object key, Object value) { }

	// RVA: 0x1BDEFF0 Offset: 0x1BDF0F1 VA: 0x1BDEFF0
	public void set_timeUpdateMode(DirectorUpdateMode value) { }

	// RVA: 0x1BDF040 Offset: 0x1BDF141 VA: 0x1BDF040
	public DirectorUpdateMode get_timeUpdateMode() { }

	// RVA: 0x1BDF090 Offset: 0x1BDF191 VA: 0x1BDF090
	public void set_time(double value) { }

	// RVA: 0x1BDF0E0 Offset: 0x1BDF1E1 VA: 0x1BDF0E0
	public double get_time() { }

	// RVA: 0x1BDF130 Offset: 0x1BDF231 VA: 0x1BDF130
	public void set_initialTime(double value) { }

	// RVA: 0x1BDF180 Offset: 0x1BDF281 VA: 0x1BDF180
	public double get_initialTime() { }

	// RVA: 0x1BDF1D0 Offset: 0x1BDF2D1 VA: 0x1BDF1D0
	public double get_duration() { }

	// RVA: 0x1BDF220 Offset: 0x1BDF321 VA: 0x1BDF220
	public void Evaluate() { }

	// RVA: 0x1BDEEE0 Offset: 0x1BDEFE1 VA: 0x1BDEEE0
	public void Play() { }

	// RVA: 0x1BDF270 Offset: 0x1BDF371 VA: 0x1BDF270
	public void Stop() { }

	// RVA: 0x1BDF2C0 Offset: 0x1BDF3C1 VA: 0x1BDF2C0
	public void Pause() { }

	// RVA: 0x1BDF310 Offset: 0x1BDF411 VA: 0x1BDF310
	public void Resume() { }

	// RVA: 0x1BDF360 Offset: 0x1BDF461 VA: 0x1BDF360
	public void RebuildGraph() { }

	// RVA: 0x1BDF3B0 Offset: 0x1BDF4B1 VA: 0x1BDF3B0 Slot: 5
	public void ClearReferenceValue(PropertyName id) { }

	// RVA: 0x1BDF460 Offset: 0x1BDF561 VA: 0x1BDF460 Slot: 6
	public void SetReferenceValue(PropertyName id, Object value) { }

	// RVA: 0x1BDF520 Offset: 0x1BDF621 VA: 0x1BDF520 Slot: 4
	public Object GetReferenceValue(PropertyName id, out bool idValid) { }

	[NativeMethodAttribute] // RVA: 0x10CF80 Offset: 0x10D081 VA: 0x10CF80
	// RVA: 0x1BDF5E0 Offset: 0x1BDF6E1 VA: 0x1BDF5E0
	public Object GetGenericBinding(Object key) { }

	[NativeMethodAttribute] // RVA: 0x10CFC0 Offset: 0x10D0C1 VA: 0x10CFC0
	// RVA: 0x1BDF630 Offset: 0x1BDF731 VA: 0x1BDF630
	public void ClearGenericBinding(Object key) { }

	// RVA: 0x1BDF680 Offset: 0x1BDF781 VA: 0x1BDF680
	public void RebindPlayableGraphOutputs() { }

	// RVA: 0x1BDF6D0 Offset: 0x1BDF7D1 VA: 0x1BDF6D0
	internal void ProcessPendingGraphChanges() { }

	[NativeMethodAttribute] // RVA: 0x10D000 Offset: 0x10D101 VA: 0x10D000
	// RVA: 0x1BDF720 Offset: 0x1BDF821 VA: 0x1BDF720
	internal bool HasGenericBinding(Object key) { }

	// RVA: 0x1BDE6B0 Offset: 0x1BDE7B1 VA: 0x1BDE6B0
	private PlayState GetPlayState() { }

	// RVA: 0x1BDE750 Offset: 0x1BDE851 VA: 0x1BDE750
	private void SetWrapMode(DirectorWrapMode mode) { }

	// RVA: 0x1BDE7F0 Offset: 0x1BDE8F1 VA: 0x1BDE7F0
	private DirectorWrapMode GetWrapMode() { }

	// RVA: 0x1BDEC60 Offset: 0x1BDED61 VA: 0x1BDEC60
	private void EvaluateNextFrame() { }

	// RVA: 0x1BDEA70 Offset: 0x1BDEB71 VA: 0x1BDEA70
	private PlayableGraph GetGraphHandle() { }

	// RVA: 0x1BDEBC0 Offset: 0x1BDECC1 VA: 0x1BDEBC0
	private void SetPlayOnAwake(bool on) { }

	// RVA: 0x1BDEB20 Offset: 0x1BDEC21 VA: 0x1BDEB20
	private bool GetPlayOnAwake() { }

	// RVA: 0x1BDEF90 Offset: 0x1BDF091 VA: 0x1BDEF90
	private void Internal_SetGenericBinding(Object key, Object value) { }

	// RVA: 0x1BDE9C0 Offset: 0x1BDEAC1 VA: 0x1BDE9C0
	private void SetPlayableAsset(ScriptableObject asset) { }

	// RVA: 0x1BDE920 Offset: 0x1BDEA21 VA: 0x1BDE920
	private ScriptableObject Internal_GetPlayableAsset() { }

	[CompilerGeneratedAttribute] // RVA: 0x10D040 Offset: 0x10D141 VA: 0x10D040
	// RVA: 0x1BDF7C0 Offset: 0x1BDF8C1 VA: 0x1BDF7C0
	public void add_played(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D050 Offset: 0x10D151 VA: 0x10D050
	// RVA: 0x1BDF870 Offset: 0x1BDF971 VA: 0x1BDF870
	public void remove_played(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D060 Offset: 0x10D161 VA: 0x10D060
	// RVA: 0x1BDF920 Offset: 0x1BDFA21 VA: 0x1BDF920
	public void add_paused(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D070 Offset: 0x10D171 VA: 0x10D070
	// RVA: 0x1BDF9D0 Offset: 0x1BDFAD1 VA: 0x1BDF9D0
	public void remove_paused(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D080 Offset: 0x10D181 VA: 0x10D080
	// RVA: 0x1BDFA80 Offset: 0x1BDFB81 VA: 0x1BDFA80
	public void add_stopped(Action<PlayableDirector> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D090 Offset: 0x10D191 VA: 0x10D090
	// RVA: 0x1BDFB30 Offset: 0x1BDFC31 VA: 0x1BDFB30
	public void remove_stopped(Action<PlayableDirector> value) { }

	[StaticAccessorAttribute] // RVA: 0x10D0A0 Offset: 0x10D1A1 VA: 0x10D0A0
	[NativeHeaderAttribute] // RVA: 0x10D0A0 Offset: 0x10D1A1 VA: 0x10D0A0
	// RVA: 0x1BDFBE0 Offset: 0x1BDFCE1 VA: 0x1BDFBE0
	internal static void ResetFrameTiming() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10D110 Offset: 0x10D211 VA: 0x10D110
	// RVA: 0x1BDFC20 Offset: 0x1BDFD21 VA: 0x1BDFC20
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10D120 Offset: 0x10D221 VA: 0x10D120
	// RVA: 0x1BDFC90 Offset: 0x1BDFD91 VA: 0x1BDFC90
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10D130 Offset: 0x10D231 VA: 0x10D130
	// RVA: 0x1BDFD00 Offset: 0x1BDFE01 VA: 0x1BDFD00
	private void SendOnPlayableDirectorStop() { }

	// RVA: 0x1BDFD70 Offset: 0x1BDFE71 VA: 0x1BDFD70
	public void .ctor() { }

	// RVA: 0x1BDF410 Offset: 0x1BDF511 VA: 0x1BDF410 Slot: 7
	private void ClearReferenceValue_Injected(ref PropertyName id) { }

	// RVA: 0x1BDF4C0 Offset: 0x1BDF5C1 VA: 0x1BDF4C0 Slot: 8
	private void SetReferenceValue_Injected(ref PropertyName id, Object value) { }

	// RVA: 0x1BDF580 Offset: 0x1BDF681 VA: 0x1BDF580 Slot: 9
	private Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid) { }

	// RVA: 0x1BDF770 Offset: 0x1BDF871 VA: 0x1BDF770
	private void GetGraphHandle_Injected(out PlayableGraph ret) { }
}

