public class ActorVoiceManager : SingletonMonoBehaviour<ActorVoiceManager> // TypeDefIndex: 6692
{
	// Fields
	private Register<ActorController, ActorVoiceController> m_Register; // 0x18
	private readonly float m_voicePlayableTime; // 0x20
	private float m_elapsed; // 0x24

	// Methods

	// RVA: 0x1BF4130 Offset: 0x1BF4231 VA: 0x1BF4130
	private void Start() { }

	// RVA: 0x1BF4150 Offset: 0x1BF4251 VA: 0x1BF4150
	private void Update() { }

	// RVA: 0x1BF4140 Offset: 0x1BF4241 VA: 0x1BF4140
	public void ResetTimeCount() { }

	// RVA: 0x1BF4320 Offset: 0x1BF4421 VA: 0x1BF4320
	public bool Regist(ActorController actorController, ActorVoiceController charaVoiceController) { }

	// RVA: 0x1BF4390 Offset: 0x1BF4491 VA: 0x1BF4390
	public void Remove(ActorController actorController) { }

	// RVA: 0x1BF4400 Offset: 0x1BF4501 VA: 0x1BF4400
	public ActorVoiceController Get(ActorController actorController) { }

	// RVA: 0x1BF4190 Offset: 0x1BF4291 VA: 0x1BF4190
	private bool CanPlayVoice() { }

	// RVA: 0x1BF44B0 Offset: 0x1BF45B1 VA: 0x1BF44B0
	public bool PlayVoice(ActorController actorController, SoundID soundID) { }

	// RVA: 0x1BF45E0 Offset: 0x1BF46E1 VA: 0x1BF45E0
	public bool PlayVoice(ActorID actorID, SoundID soundID) { }

	// RVA: 0x1BF4730 Offset: 0x1BF4831 VA: 0x1BF4730
	public bool PlayGroupVoice(ActorController actorController, VoiceGroup voiceGroup) { }

	// RVA: 0x1BF4860 Offset: 0x1BF4961 VA: 0x1BF4860
	public bool PlayGroupVoice(ActorID actorID, VoiceGroup voiceGroup) { }

	// RVA: 0x1BF49B0 Offset: 0x1BF4AB1 VA: 0x1BF49B0
	public void OnHit(ActorController actorController, StatusBase status, DamageResult damageResult) { }

	// RVA: 0x1BF49C0 Offset: 0x1BF4AC1 VA: 0x1BF49C0
	public void OnDamage(ActorController actorController, StatusBase status, DamageResult damageResult) { }

	// RVA: 0x1BF4A20 Offset: 0x1BF4B21 VA: 0x1BF4A20
	public void OnHeal(ActorController actorController) { }

	// RVA: 0x1BF4A30 Offset: 0x1BF4B31 VA: 0x1BF4A30
	public void OnLockon(ActorController actorController, CharacterBase characterBase) { }

	// RVA: 0x1BF4A40 Offset: 0x1BF4B41 VA: 0x1BF4A40
	public void OnDestroyTreasureBox(ActorController actorController) { }

	// RVA: 0x1BF4A50 Offset: 0x1BF4B51 VA: 0x1BF4A50
	public void OnDestroyGate(ActorController actorController) { }

	// RVA: 0x1BF4A60 Offset: 0x1BF4B61 VA: 0x1BF4A60
	public void OnItemGet(ActorController actorController, ItemData itemData) { }

	// RVA: 0x1BF4A70 Offset: 0x1BF4B71 VA: 0x1BF4A70
	public void OnItemUse(ActorController actorController, ItemData itemData) { }

	// RVA: 0x1BF4A80 Offset: 0x1BF4B81 VA: 0x1BF4A80
	public void OnItemThrow(ActorController actorController) { }

	// RVA: 0x1BF4A90 Offset: 0x1BF4B91 VA: 0x1BF4A90
	public void OnGreeting(ActorController actorController) { }

	// RVA: 0x1BF4BB0 Offset: 0x1BF4CB1 VA: 0x1BF4BB0
	public void .ctor() { }
}

