namespace EddiDataDefinitions
{
    /// <summary>
    /// State types for systems and factions
    /// </summary>
    public class FactionState : ResourceBasedLocalizedEDName<FactionState>
    {
        static FactionState()
        {
            resourceManager = Properties.FactionStates.ResourceManager;
            resourceManager.IgnoreCase = false;

            var Boom = new FactionState("Boom");
            var Bust = new FactionState("Bust");
            var CivilLiberty = new FactionState("CivilLiberty");
            var CivilUnrest = new FactionState("CivilUnrest");
            var CivilWar = new FactionState("CivilWar");
            var Election = new FactionState("Election");
            var Expansion = new FactionState("Expansion");
            var Famine = new FactionState("Famine");
            var Incursion = new FactionState("Incursion");
            var Investment = new FactionState("Investment");
            var Lockdown = new FactionState("Lockdown");
            var Outbreak = new FactionState("Outbreak");
            var PirateAttack = new FactionState("PirateAttack");
            var Retreat = new FactionState("Retreat");
            var War = new FactionState("War");
        }

        public static readonly FactionState None = new FactionState("None");

        // dummy used to ensure that the static constructor has run
        public FactionState() : this("")
        {}

        private FactionState(string edname) : base(edname, edname)
        {}
    }
}
