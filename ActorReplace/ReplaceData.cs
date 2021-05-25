[Serializable]
public class ReplaceData // TypeDefIndex: 11447
{
	// Fields
	[SerializeField] // RVA: 0x195110 Offset: 0x195211 VA: 0x195110
	public ActorID actorID; // 0x10
	[SerializeField] // RVA: 0x195120 Offset: 0x195221 VA: 0x195120
	public CharID charID; // 0x14
	[SerializeField] // RVA: 0x195130 Offset: 0x195231 VA: 0x195130
	public PlayerGender playerLook; // 0x18
	[SerializeField] // RVA: 0x195140 Offset: 0x195241 VA: 0x195140
	public ReplaceClip[] replaceClips; // 0x20
	[SerializeField] // RVA: 0x195150 Offset: 0x195251 VA: 0x195150
	public ReplaceAvator[] replaceAvators; // 0x28
	[SerializeField] // RVA: 0x195160 Offset: 0x195261 VA: 0x195160
	public ReplaceSound[] replaceSounds; // 0x30
	[SerializeField] // RVA: 0x195170 Offset: 0x195271 VA: 0x195170
	public ReplaceText[] replaceTexts; // 0x38

	// Methods

	// RVA: 0x1BF3140 Offset: 0x1BF3241 VA: 0x1BF3140
	public void .ctor() { }

	// RVA: 0x1BECFE0 Offset: 0x1BED0E1 VA: 0x1BECFE0
	public void ResetReplaceClip(int count) { }

	// RVA: 0x1BED180 Offset: 0x1BED281 VA: 0x1BED180
	public void ResetReplaceAvator(int count) { }

	// RVA: 0x1BED320 Offset: 0x1BED421 VA: 0x1BED320
	public void ResetReplaceSound(int count) { }

	// RVA: 0x1BED4C0 Offset: 0x1BED5C1 VA: 0x1BED4C0
	public void ResetReplaceText(int count) { }
}

