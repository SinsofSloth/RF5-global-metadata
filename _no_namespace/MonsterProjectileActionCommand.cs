public class MonsterProjectileActionCommand : MonsterActionBaseCommandBase // TypeDefIndex: 6224
{
	// Properties
	public virtual string NextActionCode { get; }
	public virtual bool UseRotate { get; }
	public virtual Vector2 DirectionBlurAngle { get; }
	public virtual float ChangeTargetDirectionAngle { get; }

	// Methods

	// RVA: 0x1CD3600 Offset: 0x1CD3701 VA: 0x1CD3600 Slot: 13
	public virtual string get_NextActionCode() { }

	// RVA: 0x1CD3620 Offset: 0x1CD3721 VA: 0x1CD3620 Slot: 14
	public virtual bool get_UseRotate() { }

	// RVA: 0x1CD3640 Offset: 0x1CD3741 VA: 0x1CD3640 Slot: 15
	public virtual Vector2 get_DirectionBlurAngle() { }

	// RVA: 0x1CD3660 Offset: 0x1CD3761 VA: 0x1CD3660 Slot: 16
	public virtual float get_ChangeTargetDirectionAngle() { }

	// RVA: 0x1CD3680 Offset: 0x1CD3781 VA: 0x1CD3680
	public void .ctor(ActionCommandDataTable actionCommandData, MonsterActionScriptsControllerBase controller) { }

	// RVA: 0x1CD36E0 Offset: 0x1CD37E1 VA: 0x1CD36E0 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1CD38B0 Offset: 0x1CD39B1 VA: 0x1CD38B0 Slot: 17
	protected virtual void ProjcticlePostprocess(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController) { }
}

