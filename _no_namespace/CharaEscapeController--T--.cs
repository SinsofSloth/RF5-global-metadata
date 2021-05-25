public abstract class CharaEscapeController<T> : EscapeController // TypeDefIndex: 6584
{
	// Fields
	protected CharaEscapeController.State<T> m_State; // 0x0
	protected ParticleSystem m_AuraEffect; // 0x0
	protected EscapeShineBall m_ShineBall; // 0x0
	protected Transform m_AuraAttachPoint; // 0x0
	[SerializeField] // RVA: 0x15D830 Offset: 0x15D931 VA: 0x15D830
	protected T m_chara; // 0x0

	// Properties
	public override bool IsPlaying { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override bool get_IsPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2573A60 Offset: 0x2573B61 VA: 0x2573A60
	|-CharaEscapeController<HumanController>.get_IsPlaying
	|-CharaEscapeController<MonsterControllerBase>.get_IsPlaying
	|-CharaEscapeController<object>.get_IsPlaying
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2573A70 Offset: 0x2573B71 VA: 0x2573A70
	|-CharaEscapeController<HumanController>.Awake
	|-CharaEscapeController<MonsterControllerBase>.Awake
	|-CharaEscapeController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2573BB0 Offset: 0x2573CB1 VA: 0x2573BB0
	|-CharaEscapeController<HumanController>.OnDestroy
	|-CharaEscapeController<MonsterControllerBase>.OnDestroy
	|-CharaEscapeController<object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool DoRise(Action callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2573C80 Offset: 0x2573D81 VA: 0x2573C80
	|-CharaEscapeController<HumanController>.DoRise
	|-CharaEscapeController<MonsterControllerBase>.DoRise
	|-CharaEscapeController<object>.DoRise
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool DoFall(Action callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2574120 Offset: 0x2574221 VA: 0x2574120
	|-CharaEscapeController<HumanController>.DoFall
	|-CharaEscapeController<MonsterControllerBase>.DoFall
	|-CharaEscapeController<object>.DoFall
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void DoEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2574400 Offset: 0x2574501 VA: 0x2574400
	|-CharaEscapeController<HumanController>.DoEnd
	|-CharaEscapeController<MonsterControllerBase>.DoEnd
	|-CharaEscapeController<object>.DoEnd
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void DoCancel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2574520 Offset: 0x2574621 VA: 0x2574520
	|-CharaEscapeController<HumanController>.DoCancel
	|-CharaEscapeController<MonsterControllerBase>.DoCancel
	|-CharaEscapeController<object>.DoCancel
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override bool DoTakeOff() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25746D0 Offset: 0x25747D1 VA: 0x25746D0
	|-CharaEscapeController<HumanController>.DoTakeOff
	|-CharaEscapeController<MonsterControllerBase>.DoTakeOff
	|-CharaEscapeController<object>.DoTakeOff
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnEndRise() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2574990 Offset: 0x2574A91 VA: 0x2574990
	|-CharaEscapeController<HumanController>.OnEndRise
	|-CharaEscapeController<MonsterControllerBase>.OnEndRise
	|-CharaEscapeController<object>.OnEndRise
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void OnEndFall() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2574AA0 Offset: 0x2574BA1 VA: 0x2574AA0
	|-CharaEscapeController<HumanController>.OnEndFall
	|-CharaEscapeController<MonsterControllerBase>.OnEndFall
	|-CharaEscapeController<object>.OnEndFall
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2574BB0 Offset: 0x2574CB1 VA: 0x2574BB0
	|-CharaEscapeController<HumanController>..ctor
	|-CharaEscapeController<MonsterControllerBase>..ctor
	|-CharaEscapeController<object>..ctor
	*/
}

