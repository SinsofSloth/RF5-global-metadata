[DefaultMemberAttribute] // RVA: 0xE9130 Offset: 0xE9231 VA: 0xE9130
public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 3510
{
	// Properties
	public AnimationClip clip { get; set; }
	public bool playAutomatically { get; set; }
	public WrapMode wrapMode { get; set; }
	public bool isPlaying { get; }
	public AnimationState Item { get; }
	public bool animatePhysics { get; set; }
	[ObsoleteAttribute] // RVA: 0xEE670 Offset: 0xEE771 VA: 0xEE670
	public bool animateOnlyIfVisible { get; set; }
	public AnimationCullingType cullingType { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC630 Offset: 0xEC731 VA: 0xEC630
	// RVA: 0x1AEB040 Offset: 0x1AEB141 VA: 0x1AEB040
	public AnimationClip get_clip() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC640 Offset: 0xEC741 VA: 0xEC640
	// RVA: 0x1AEB090 Offset: 0x1AEB191 VA: 0x1AEB090
	public void set_clip(AnimationClip value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC650 Offset: 0xEC751 VA: 0xEC650
	// RVA: 0x1AEB0E0 Offset: 0x1AEB1E1 VA: 0x1AEB0E0
	public bool get_playAutomatically() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC660 Offset: 0xEC761 VA: 0xEC660
	// RVA: 0x1AEB130 Offset: 0x1AEB231 VA: 0x1AEB130
	public void set_playAutomatically(bool value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC670 Offset: 0xEC771 VA: 0xEC670
	// RVA: 0x1AEB180 Offset: 0x1AEB281 VA: 0x1AEB180
	public WrapMode get_wrapMode() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC680 Offset: 0xEC781 VA: 0xEC680
	// RVA: 0x1AEB1D0 Offset: 0x1AEB2D1 VA: 0x1AEB1D0
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x1AEB220 Offset: 0x1AEB321 VA: 0x1AEB220
	public void Stop() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC690 Offset: 0xEC791 VA: 0xEC690
	// RVA: 0x1AEB270 Offset: 0x1AEB371 VA: 0x1AEB270
	private static void INTERNAL_CALL_Stop(Animation self) { }

	// RVA: 0x1AEB2C0 Offset: 0x1AEB3C1 VA: 0x1AEB2C0
	public void Stop(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC6A0 Offset: 0xEC7A1 VA: 0xEC6A0
	// RVA: 0x1AEB310 Offset: 0x1AEB411 VA: 0x1AEB310
	private void Internal_StopByName(string name) { }

	// RVA: 0x1AEB360 Offset: 0x1AEB461 VA: 0x1AEB360
	public void Rewind(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC6B0 Offset: 0xEC7B1 VA: 0xEC6B0
	// RVA: 0x1AEB3B0 Offset: 0x1AEB4B1 VA: 0x1AEB3B0
	private void Internal_RewindByName(string name) { }

	// RVA: 0x1AEB400 Offset: 0x1AEB501 VA: 0x1AEB400
	public void Rewind() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC6C0 Offset: 0xEC7C1 VA: 0xEC6C0
	// RVA: 0x1AEB450 Offset: 0x1AEB551 VA: 0x1AEB450
	private static void INTERNAL_CALL_Rewind(Animation self) { }

	// RVA: 0x1AEB4A0 Offset: 0x1AEB5A1 VA: 0x1AEB4A0
	public void Sample() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC6D0 Offset: 0xEC7D1 VA: 0xEC6D0
	// RVA: 0x1AEB4F0 Offset: 0x1AEB5F1 VA: 0x1AEB4F0
	private static void INTERNAL_CALL_Sample(Animation self) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC6E0 Offset: 0xEC7E1 VA: 0xEC6E0
	// RVA: 0x1AEB540 Offset: 0x1AEB641 VA: 0x1AEB540
	public bool get_isPlaying() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC6F0 Offset: 0xEC7F1 VA: 0xEC6F0
	// RVA: 0x1AEB590 Offset: 0x1AEB691 VA: 0x1AEB590
	public bool IsPlaying(string name) { }

	// RVA: 0x1AEB5E0 Offset: 0x1AEB6E1 VA: 0x1AEB5E0
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC700 Offset: 0xEC801 VA: 0xEC700
	// RVA: 0x1AEB680 Offset: 0x1AEB781 VA: 0x1AEB680
	public bool Play() { }

	// RVA: 0x1AEB6D0 Offset: 0x1AEB7D1 VA: 0x1AEB6D0
	public bool Play(PlayMode mode) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC710 Offset: 0xEC811 VA: 0xEC710
	// RVA: 0x1AEB770 Offset: 0x1AEB871 VA: 0x1AEB770
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC720 Offset: 0xEC821 VA: 0xEC720
	// RVA: 0x1AEB7D0 Offset: 0x1AEB8D1 VA: 0x1AEB7D0
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC730 Offset: 0xEC831 VA: 0xEC730
	// RVA: 0x1AEB830 Offset: 0x1AEB931 VA: 0x1AEB830
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC740 Offset: 0xEC841 VA: 0xEC740
	// RVA: 0x1AEB8A0 Offset: 0x1AEB9A1 VA: 0x1AEB8A0
	public void CrossFade(string animation, float fadeLength) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC750 Offset: 0xEC851 VA: 0xEC750
	// RVA: 0x1AEB910 Offset: 0x1AEBA11 VA: 0x1AEB910
	public void CrossFade(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC760 Offset: 0xEC861 VA: 0xEC760
	// RVA: 0x1AEB970 Offset: 0x1AEBA71 VA: 0x1AEB970
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC770 Offset: 0xEC871 VA: 0xEC770
	// RVA: 0x1AEB9E0 Offset: 0x1AEBAE1 VA: 0x1AEB9E0
	public void Blend(string animation, float targetWeight) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC780 Offset: 0xEC881 VA: 0xEC780
	// RVA: 0x1AEBA50 Offset: 0x1AEBB51 VA: 0x1AEBA50
	public void Blend(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC790 Offset: 0xEC891 VA: 0xEC790
	// RVA: 0x1AEBAB0 Offset: 0x1AEBBB1 VA: 0x1AEBAB0
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC7A0 Offset: 0xEC8A1 VA: 0xEC7A0
	// RVA: 0x1AEBB30 Offset: 0x1AEBC31 VA: 0x1AEBB30
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC7B0 Offset: 0xEC8B1 VA: 0xEC7B0
	// RVA: 0x1AEBBA0 Offset: 0x1AEBCA1 VA: 0x1AEBBA0
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC7C0 Offset: 0xEC8C1 VA: 0xEC7C0
	// RVA: 0x1AEBC10 Offset: 0x1AEBD11 VA: 0x1AEBC10
	public AnimationState CrossFadeQueued(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC7D0 Offset: 0xEC8D1 VA: 0xEC7D0
	// RVA: 0x1AEBC70 Offset: 0x1AEBD71 VA: 0x1AEBC70
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC7E0 Offset: 0xEC8E1 VA: 0xEC7E0
	// RVA: 0x1AEBCE0 Offset: 0x1AEBDE1 VA: 0x1AEBCE0
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC7F0 Offset: 0xEC8F1 VA: 0xEC7F0
	// RVA: 0x1AEBD40 Offset: 0x1AEBE41 VA: 0x1AEBD40
	public AnimationState PlayQueued(string animation) { }

	// RVA: 0x1AEBDA0 Offset: 0x1AEBEA1 VA: 0x1AEBDA0
	public void AddClip(AnimationClip clip, string newName) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC800 Offset: 0xEC901 VA: 0xEC800
	// RVA: 0x1AEBE90 Offset: 0x1AEBF91 VA: 0x1AEBE90
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	[ExcludeFromDocsAttribute] // RVA: 0xEC810 Offset: 0xEC911 VA: 0xEC810
	// RVA: 0x1AEBE10 Offset: 0x1AEBF11 VA: 0x1AEBE10
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC820 Offset: 0xEC921 VA: 0xEC820
	// RVA: 0x1AEBF10 Offset: 0x1AEC011 VA: 0x1AEBF10
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x1AEBF60 Offset: 0x1AEC061 VA: 0x1AEBF60
	public void RemoveClip(string clipName) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC830 Offset: 0xEC931 VA: 0xEC830
	// RVA: 0x1AEC000 Offset: 0x1AEC101 VA: 0x1AEC000
	public int GetClipCount() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC840 Offset: 0xEC941 VA: 0xEC840
	// RVA: 0x1AEBFB0 Offset: 0x1AEC0B1 VA: 0x1AEBFB0
	private void RemoveClip2(string clipName) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC850 Offset: 0xEC951 VA: 0xEC850
	// RVA: 0x1AEB720 Offset: 0x1AEB821 VA: 0x1AEB720
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[ObsoleteAttribute] // RVA: 0xEC860 Offset: 0xEC961 VA: 0xEC860
	// RVA: 0x1AEC050 Offset: 0x1AEC151 VA: 0x1AEC050
	public bool Play(AnimationPlayMode mode) { }

	[ObsoleteAttribute] // RVA: 0xEC8A0 Offset: 0xEC9A1 VA: 0xEC8A0
	// RVA: 0x1AEC0A0 Offset: 0x1AEC1A1 VA: 0x1AEC0A0
	public bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x1AEC100 Offset: 0x1AEC201 VA: 0x1AEC100
	public void SyncLayer(int layer) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC8E0 Offset: 0xEC9E1 VA: 0xEC8E0
	// RVA: 0x1AEC150 Offset: 0x1AEC251 VA: 0x1AEC150
	private static void INTERNAL_CALL_SyncLayer(Animation self, int layer) { }

	// RVA: 0x1AEC1A0 Offset: 0x1AEC2A1 VA: 0x1AEC1A0 Slot: 4
	public IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC8F0 Offset: 0xEC9F1 VA: 0xEC8F0
	// RVA: 0x1AEB630 Offset: 0x1AEB731 VA: 0x1AEB630
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC900 Offset: 0xECA01 VA: 0xEC900
	// RVA: 0x1AEC260 Offset: 0x1AEC361 VA: 0x1AEC260
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC910 Offset: 0xECA11 VA: 0xEC910
	// RVA: 0x1AEC2B0 Offset: 0x1AEC3B1 VA: 0x1AEC2B0
	internal int GetStateCount() { }

	// RVA: 0x1AEC300 Offset: 0x1AEC401 VA: 0x1AEC300
	public AnimationClip GetClip(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC920 Offset: 0xECA21 VA: 0xEC920
	// RVA: 0x1AEC400 Offset: 0x1AEC501 VA: 0x1AEC400
	public bool get_animatePhysics() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC930 Offset: 0xECA31 VA: 0xEC930
	// RVA: 0x1AEC450 Offset: 0x1AEC551 VA: 0x1AEC450
	public void set_animatePhysics(bool value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC940 Offset: 0xECA41 VA: 0xEC940
	// RVA: 0x1AEC4A0 Offset: 0x1AEC5A1 VA: 0x1AEC4A0
	public bool get_animateOnlyIfVisible() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC950 Offset: 0xECA51 VA: 0xEC950
	// RVA: 0x1AEC4F0 Offset: 0x1AEC5F1 VA: 0x1AEC4F0
	public void set_animateOnlyIfVisible(bool value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC960 Offset: 0xECA61 VA: 0xEC960
	// RVA: 0x1AEC540 Offset: 0x1AEC641 VA: 0x1AEC540
	public AnimationCullingType get_cullingType() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC970 Offset: 0xECA71 VA: 0xEC970
	// RVA: 0x1AEC590 Offset: 0x1AEC691 VA: 0x1AEC590
	public void set_cullingType(AnimationCullingType value) { }

	// RVA: 0x1AEC5E0 Offset: 0x1AEC6E1 VA: 0x1AEC5E0
	public Bounds get_localBounds() { }

	// RVA: 0x1AEC6A0 Offset: 0x1AEC7A1 VA: 0x1AEC6A0
	public void set_localBounds(Bounds value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC980 Offset: 0xECA81 VA: 0xEC980
	// RVA: 0x1AEC650 Offset: 0x1AEC751 VA: 0x1AEC650
	private void INTERNAL_get_localBounds(out Bounds value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEC990 Offset: 0xECA91 VA: 0xEC990
	// RVA: 0x1AEC6F0 Offset: 0x1AEC7F1 VA: 0x1AEC6F0
	private void INTERNAL_set_localBounds(ref Bounds value) { }

	// RVA: 0x1AEC740 Offset: 0x1AEC841 VA: 0x1AEC740
	public void .ctor() { }
}

