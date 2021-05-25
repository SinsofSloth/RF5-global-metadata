public abstract class CharaLazyController<T> : LazyController // TypeDefIndex: 6594
{
	// Fields
	[SerializeField] // RVA: 0x15D930 Offset: 0x15DA31 VA: 0x15D930
	protected T m_chara; // 0x0
	[SerializeField] // RVA: 0x15D940 Offset: 0x15DA41 VA: 0x15D940
	private EmotionController m_EmotionController; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576AF0 Offset: 0x2576BF1 VA: 0x2576AF0
	|-CharaLazyController<HumanController>.Awake
	|-CharaLazyController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576C10 Offset: 0x2576D11 VA: 0x2576C10
	|-CharaLazyController<HumanController>.OnEnable
	|-CharaLazyController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576CE0 Offset: 0x2576DE1 VA: 0x2576CE0
	|-CharaLazyController<HumanController>.OnDisable
	|-CharaLazyController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void DoUpdateEmotion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576DC0 Offset: 0x2576EC1 VA: 0x2576DC0
	|-CharaLazyController<HumanController>.DoUpdateEmotion
	|-CharaLazyController<object>.DoUpdateEmotion
	*/

	// RVA: -1 Offset: -1
	public void DoPlayEmotion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576E00 Offset: 0x2576F01 VA: 0x2576E00
	|-CharaLazyController<object>.DoPlayEmotion
	*/

	// RVA: -1 Offset: -1
	public void DoStopEmotion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576EB0 Offset: 0x2576FB1 VA: 0x2576EB0
	|-CharaLazyController<object>.DoStopEmotion
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576F60 Offset: 0x2577061 VA: 0x2576F60
	|-CharaLazyController<HumanController>..ctor
	|-CharaLazyController<object>..ctor
	*/
}

