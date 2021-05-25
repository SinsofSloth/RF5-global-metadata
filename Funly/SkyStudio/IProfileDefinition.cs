public interface IProfileDefinition // TypeDefIndex: 9673
{
	// Properties
	public abstract string shaderName { get; }
	public abstract ProfileFeatureSection[] features { get; }
	public abstract ProfileGroupSection[] groups { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_shaderName() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ProfileFeatureSection[] get_features() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ProfileGroupSection[] get_groups() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ProfileFeatureDefinition GetFeatureDefinition(string featureKey) { }
}

