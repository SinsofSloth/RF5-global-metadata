[Serializable]
public enum EnemyBehaviorTreeState // TypeDefIndex: 6416
{
	// Fields
	public int value__; // 0x0
	public const EnemyBehaviorTreeState None = 0;
	public const EnemyBehaviorTreeState Patroll_Default = 1;
	public const EnemyBehaviorTreeState Patroll_Sleep = 2;
	public const EnemyBehaviorTreeState Caution = 3;
	public const EnemyBehaviorTreeState Battle = 4;
	public const EnemyBehaviorTreeState ReturnPatrolPoint = 5;
}

