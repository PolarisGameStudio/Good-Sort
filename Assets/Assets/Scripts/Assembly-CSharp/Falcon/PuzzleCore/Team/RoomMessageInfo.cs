using System;

namespace Falcon.PuzzleCore.Team
{
	[Serializable]
	public class RoomMessageInfo
	{
		public int sender_code;

		public int sender_avatar_id;

		public string sender_avatar_url;

		public string sender_name;

		public int receiver_code;

		public long room_message_id;

		public long room_message_update_id;

		public string room_message_uuid;

		public string room_message_type;

		public string room_message_content;

		public bool room_message_interact_available;

		public string room_type;

		public string room_id;

		public long created_date;

		public int sender_frame_id;

		public long sender_frame_expiration;

		public int sender_name_style;

		public long expired_date;
	}
}
