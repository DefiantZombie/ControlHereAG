### Pre-Build
* Update AssemblyInfo for <project name> project
* Update `Resources\GameData\<project name>\<project name>.version`
* Update `Resources\GameData\<project name>\Changelog.txt`
* Update if required `Resources\GameData\<project name>\Readme.txt`

### Build
* Build solution in release mode
* Create zip file from `Resources\GameData\` (<project name> folder)
* Name the zip file `<project name>-ksp<version>-v<major>.<minor>.<patch>.<build>.zip` (eg <project name>-ksp1.3-v1.0.0.0.zip)

### Post-Build
* Verify Github master matches local master
* Create release tag and push to Github
* Update Github release info and add binary
* Update AVC information on [KSP AVC Online](http://ksp-avc.cybutek.net/?page=My_Versions)
* Post update in the forum thread [KSP Forums](http://forum.kerbalspaceprogram.com/index.php?/topic/155635-12-controlhereag-v100/)
