[DefaultMemberAttribute] // RVA: 0x141220 Offset: 0x141321 VA: 0x141220
private class SimpleAnimationPlayable.StateManagement // TypeDefIndex: 5935
{
	// Fields
	private List<SimpleAnimationPlayable.StateInfo> m_States; // 0x10
	private int m_Count; // 0x18

	// Properties
	public int Count { get; }
	public SimpleAnimationPlayable.StateInfo Item { get; }

	// Methods

	// RVA: 0x1B8F6D0 Offset: 0x1B8F7D1 VA: 0x1B8F6D0
	public int get_Count() { }

	// RVA: 0x1B8A0E0 Offset: 0x1B8A1E1 VA: 0x1B8A0E0
	public SimpleAnimationPlayable.StateInfo get_Item(int i) { }

	// RVA: 0x1B8A430 Offset: 0x1B8A531 VA: 0x1B8A430
	public void .ctor() { }

	// RVA: 0x1B8AAB0 Offset: 0x1B8ABB1 VA: 0x1B8AAB0
	public SimpleAnimationPlayable.StateInfo InsertState() { }

	// RVA: 0x1B8B8D0 Offset: 0x1B8B9D1 VA: 0x1B8B8D0
	public bool AnyStatePlaying() { }

	// RVA: 0x1B8AF70 Offset: 0x1B8B071 VA: 0x1B8AF70
	public void RemoveState(int index) { }

	// RVA: 0x1B8B040 Offset: 0x1B8B141 VA: 0x1B8B040
	public bool RemoveClip(AnimationClip clip) { }

	// RVA: 0x1B8A720 Offset: 0x1B8A821 VA: 0x1B8A720
	public SimpleAnimationPlayable.StateInfo FindState(string name) { }

	// RVA: 0x1B8BEE0 Offset: 0x1B8BFE1 VA: 0x1B8BEE0
	public void EnableState(int index) { }

	// RVA: 0x1B8DFB0 Offset: 0x1B8E0B1 VA: 0x1B8DFB0
	public void DisableState(int index) { }

	// RVA: 0x1B8EDC0 Offset: 0x1B8EEC1 VA: 0x1B8EDC0
	public void SetInputWeight(int index, float weight) { }

	// RVA: 0x1B8B720 Offset: 0x1B8B821 VA: 0x1B8B720
	public void SetStateTime(int index, float time) { }

	// RVA: 0x1B8D110 Offset: 0x1B8D211 VA: 0x1B8D110
	public float GetStateTime(int index) { }

	// RVA: 0x1B8F6F0 Offset: 0x1B8F7F1 VA: 0x1B8F6F0
	public bool IsCloneOf(int potentialCloneIndex, int originalIndex) { }

	// RVA: 0x1B8E5C0 Offset: 0x1B8E6C1 VA: 0x1B8E5C0
	public float GetStateSpeed(int index) { }

	// RVA: 0x1B8E740 Offset: 0x1B8E841 VA: 0x1B8E740
	public void SetStateSpeed(int index, float value) { }

	// RVA: 0x1B8F7A0 Offset: 0x1B8F8A1 VA: 0x1B8F7A0
	public float GetInputWeight(int index) { }

	// RVA: 0x1B8EF10 Offset: 0x1B8F011 VA: 0x1B8EF10
	public float GetStateLength(int index) { }

	// RVA: 0x1B8E2F0 Offset: 0x1B8E3F1 VA: 0x1B8E2F0
	public float GetClipLength(int index) { }

	// RVA: 0x1B8F820 Offset: 0x1B8F921 VA: 0x1B8F820
	public float GetStatePlayableDuration(int index) { }

	// RVA: 0x1B8F180 Offset: 0x1B8F281 VA: 0x1B8F180
	public AnimationClip GetStateClip(int index) { }

	// RVA: 0x1B8F310 Offset: 0x1B8F411 VA: 0x1B8F310
	public WrapMode GetStateWrapMode(int index) { }

	// RVA: 0x1B8E910 Offset: 0x1B8EA11 VA: 0x1B8E910
	public string GetStateName(int index) { }

	// RVA: 0x1B8EAD0 Offset: 0x1B8EBD1 VA: 0x1B8EAD0
	public void SetStateName(int index, string name) { }

	// RVA: 0x1B8B7B0 Offset: 0x1B8B8B1 VA: 0x1B8B7B0
	public void StopState(int index, bool cleanup) { }
}

