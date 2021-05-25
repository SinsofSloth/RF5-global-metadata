[Serializable]
public class CompareAnimatorParam // TypeDefIndex: 6206
{
	// Fields
	[SerializeField] // RVA: 0x15BCD0 Offset: 0x15BDD1 VA: 0x15BCD0
	public string m_CompareParamName; // 0x10
	[SerializeField] // RVA: 0x15BCE0 Offset: 0x15BDE1 VA: 0x15BCE0
	public ComparisonOperatorsType m_OperatorType; // 0x18
	[SerializeField] // RVA: 0x15BCF0 Offset: 0x15BDF1 VA: 0x15BCF0
	public VariableType m_VariableType; // 0x1C
	[SerializeField] // RVA: 0x15BD00 Offset: 0x15BE01 VA: 0x15BD00
	public int m_ParamInt; // 0x20
	[SerializeField] // RVA: 0x15BD10 Offset: 0x15BE11 VA: 0x15BD10
	public float m_ParamFloat; // 0x24
	[SerializeField] // RVA: 0x15BD20 Offset: 0x15BE21 VA: 0x15BD20
	public bool m_ParamBool; // 0x28
	private Func<bool> m_CheckCompare; // 0x30
	private int m_CompareParamHash; // 0x38

	// Methods

	// RVA: 0x1FC5700 Offset: 0x1FC5801 VA: 0x1FC5700
	public bool CheckCompare(Animator animator, bool returnNotSetParameter) { }

	// RVA: 0x1FC5AF0 Offset: 0x1FC5BF1 VA: 0x1FC5AF0
	public void .ctor() { }
}

