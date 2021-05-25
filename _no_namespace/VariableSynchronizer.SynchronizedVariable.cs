[Serializable]
public class VariableSynchronizer.SynchronizedVariable // TypeDefIndex: 4703
{
	// Fields
	public VariableSynchronizer.SynchronizationType synchronizationType; // 0x10
	public bool setVariable; // 0x14
	public Behavior behavior; // 0x18
	public string variableName; // 0x20
	public bool global; // 0x28
	public Component targetComponent; // 0x30
	public string targetName; // 0x38
	public bool targetGlobal; // 0x40
	public SharedVariable targetSharedVariable; // 0x48
	public Action<object> setDelegate; // 0x50
	public Func<object> getDelegate; // 0x58
	public Animator animator; // 0x60
	public VariableSynchronizer.AnimatorParameterType animatorParameterType; // 0x68
	public int targetID; // 0x6C
	public Action<VariableSynchronizer.SynchronizedVariable> thirdPartyTick; // 0x70
	public Enum variableType; // 0x78
	public object thirdPartyVariable; // 0x80
	public SharedVariable sharedVariable; // 0x88
}

