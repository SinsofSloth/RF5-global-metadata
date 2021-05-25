public abstract class MagicController : MonoBehaviour // TypeDefIndex: 6595
{
	// Fields
	[SerializeField] // RVA: 0x15D950 Offset: 0x15DA51 VA: 0x15D950
	protected List<Collider> m_Targets; // 0x18
	protected List<CharacterBase> m_TargetCharas; // 0x20
	protected AS_MagicController m_Spawner; // 0x28
	protected float elapsed; // 0x30
	protected float minDuration; // 0x34
	protected float maxDuration; // 0x38
	private List<BulletBase> bulletList; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15D960 Offset: 0x15DA61 VA: 0x15D960
	private bool <IsBulletExtension>k__BackingField; // 0x48

	// Properties
	public bool IsPlaying { get; }
	public List<Collider> Targets { get; }
	public bool IsBulletExtension { get; set; }

	// Methods

	// RVA: 0x1E0C110 Offset: 0x1E0C211 VA: 0x1E0C110
	public bool get_IsPlaying() { }

	// RVA: 0x1E0C180 Offset: 0x1E0C281 VA: 0x1E0C180
	public List<Collider> get_Targets() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B920 Offset: 0x19BA21 VA: 0x19B920
	// RVA: 0x1E0C190 Offset: 0x1E0C291 VA: 0x1E0C190
	public bool get_IsBulletExtension() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B930 Offset: 0x19BA31 VA: 0x19B930
	// RVA: 0x1E0C1A0 Offset: 0x1E0C2A1 VA: 0x1E0C1A0
	protected void set_IsBulletExtension(bool value) { }

	// RVA: 0x1E0C1B0 Offset: 0x1E0C2B1 VA: 0x1E0C1B0 Slot: 4
	public virtual bool CanPlay() { }

	// RVA: 0x1E0C1C0 Offset: 0x1E0C2C1 VA: 0x1E0C1C0 Slot: 5
	public virtual void OnUpdate() { }

	// RVA: 0x1E0C2B0 Offset: 0x1E0C3B1 VA: 0x1E0C2B0 Slot: 6
	public virtual bool DoPlay(MagicID magicId, int level, AttackAttribute attribute, Vector3 offset, float rpRate) { }

	// RVA: 0x1E0C2C0 Offset: 0x1E0C3C1 VA: 0x1E0C2C0 Slot: 7
	public virtual void DoStop() { }

	// RVA: 0x1E0C3A0 Offset: 0x1E0C4A1 VA: 0x1E0C3A0 Slot: 8
	public virtual List<Collider> GetTargets() { }

	// RVA: 0x1E0C3B0 Offset: 0x1E0C4B1 VA: 0x1E0C3B0 Slot: 9
	public virtual void ClearBullet() { }

	// RVA: 0x1E0C530 Offset: 0x1E0C631 VA: 0x1E0C530 Slot: 10
	public virtual void AddBullet(BulletBase bullet) { }

	// RVA: 0x1E0C5B0 Offset: 0x1E0C6B1 VA: 0x1E0C5B0
	public void StartBulletExtension() { }

	// RVA: 0x1E0C390 Offset: 0x1E0C491 VA: 0x1E0C390
	public void StopBulletExtension() { }

	// RVA: 0x1E0C5C0 Offset: 0x1E0C6C1 VA: 0x1E0C5C0
	protected void .ctor() { }
}

