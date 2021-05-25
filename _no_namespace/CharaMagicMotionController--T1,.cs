public abstract class CharaMagicMotionController<T1, T2> : MagicMotionController // TypeDefIndex: 6598
{
	// Fields
	[SerializeField] // RVA: 0x15D990 Offset: 0x15DA91 VA: 0x15D990
	protected T1 m_chara; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2578150 Offset: 0x2578251 VA: 0x2578150
	|-CharaMagicMotionController<HumanController, HumanMagicMotionType>.Awake
	|-CharaMagicMotionController<object, Int32Enum>.Awake
	|
	|-RVA: 0x2578310 Offset: 0x2578411 VA: 0x2578310
	|-CharaMagicMotionController<object, object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Setup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2578210 Offset: 0x2578311 VA: 0x2578210
	|-CharaMagicMotionController<HumanController, HumanMagicMotionType>.Setup
	|-CharaMagicMotionController<object, Int32Enum>.Setup
	|
	|-RVA: 0x25783D0 Offset: 0x25784D1 VA: 0x25783D0
	|-CharaMagicMotionController<object, object>.Setup
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool DoPlay(T2 motion, MagicID magicId, int level) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CharaMagicMotionController<object, object>.DoPlay
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25782F0 Offset: 0x25783F1 VA: 0x25782F0
	|-CharaMagicMotionController<HumanController, HumanMagicMotionType>..ctor
	|-CharaMagicMotionController<object, Int32Enum>..ctor
	|
	|-RVA: 0x25784B0 Offset: 0x25785B1 VA: 0x25784B0
	|-CharaMagicMotionController<object, object>..ctor
	*/
}

