namespace ControlHereAG
{
    // ReSharper disable once InconsistentNaming
    public class ModuleControlHereAG : PartModule
    {
        private ModuleDockingNode _dockingModule;
        private ModuleCommand _commandModule;

        private bool _disabled = true;

        [KSPAction(actionGroup = KSPActionGroup.None, advancedTweakable = true,
            guiName = "#SSC_CHAG_000001")]
        public void ControlHereAction(KSPActionParam param)
        {
            if (_disabled) return;

            if (_dockingModule)
            {
                _dockingModule.MakeReferenceTransform();
            }
            else if (_commandModule)
            {
                _commandModule.MakeReference();
            }
        }

        public override void OnAwake()
        {
            _dockingModule = part.Modules.GetModule<ModuleDockingNode>();
            _commandModule = part.Modules.GetModule<ModuleCommand>();

            if (_dockingModule || _commandModule)
                _disabled = false;
        }
    }
}
