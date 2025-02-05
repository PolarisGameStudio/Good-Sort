using System;

namespace Falcon.PuzzleCore.UserData
{
	[Serializable]
	public class ApkInfo
	{
		public string app_version;

		public int app_version_int;

		public string install_vendor;

		public int number_lib_files;

		public long total_lib_file_size;

		public string lib_file_name_list;

		public string lib_folder;

		public string lib_md5;

		public string package_name;
	}
}
