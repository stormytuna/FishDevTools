namespace FishDevTools.Tools;

public class UnlockBestiary : ModPlayer
{
	public override void OnEnterWorld() {
		foreach (NPC npc in ContentSamples.NpcsByNetId.Values) {
			string bestiaryCreditId = npc.GetBestiaryCreditId();

			if (npc.isLikeATownNPC) {
				Main.BestiaryTracker.Chats.SetWasChatWithDirectly(bestiaryCreditId);
			} else if (npc.CountsAsACritter) {
				Main.BestiaryTracker.Sights.SetWasSeenDirectly(bestiaryCreditId);
			}
			else {
				Main.BestiaryTracker.Kills.SetKillCountDirectly(bestiaryCreditId, 1000);
			}
		}
	}
}
