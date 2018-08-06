private void SVNCommit()
{
	using (SvnClient client = new SvnClient())
	{
		// Update the specified working copy path to the head revision
		client.Update("C:\\PROJECTS\\BOX_AMBALAJ");
		
		// Commit the changes with the specified logmessage
		SvnCommitArgs ca = new SvnCommitArgs();
		ca.LogMessage = "Moved from.txt to new.txt";
		client.Commit("C:\\PROJECTS\\BOX_AMBALAJ", ca);
	}
}