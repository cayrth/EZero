using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Runtime.Security
{
    public class IdentityServerConfig
    {

        public const string ApiName = "api";

        public const string DisplayName = "EZero Api";

        //所有可以访问的Resource
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource(ApiName, DisplayName)
            };
        }

        //客户端
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                    ClientId="client",
                    // 没有交互性用户，使用 clientid/secret 实现认证。
                    AllowedGrantTypes = GrantTypes.ClientCredentials,//模式：最简单的模式

                    // 用于认证的密码
                    ClientSecrets={ //私钥
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes={ //可以访问的Resource
                        "api"
                    }
                },
                new Client()
                {
                    ClientId="pwdClient",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,//模式：密码模式
                    // 用于认证的密码
                    ClientSecrets={//私钥
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes={//可以访问的Resource
                        "api"
                    }
                }
            };
        }
    }
}
