using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAPIWrapper.JSONBases
{
    internal class Authenticate
    {
        public string accessToken;
        public string clientToken;
        public List<_profile> profiles;
        public _profile selectedProfile;
        public _user user;
        public class _user
        {
            public string id;
            public string email;
            public string username;
            public string registerIp;
            public long migratedFrom;
            public long registeredAt;
            public long passwordChangedAt;
            public long dateOfBirth;
            public bool suspended;
            public bool blocked;
            public bool secured;
            public bool migrated;
            public bool emailVerified;
            public bool legacyUser;
            public bool verifiedByParent;
            public List<_property> properties;
            public class _property
            {
                public string name;
                public string value;
            }
        }
        public class _profile
        {
            public string agent;
            public string id;
            public string name;
            public string userid;
            public long createdAt;
            public bool legacyProfile;
            public bool suspended;
            public bool paid;
            public bool migrated;
            public bool legacy;
        }
    }
}
