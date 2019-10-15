﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Qmmands;

namespace Disqord.Bot.Parsers
{
    public sealed class CachedRoleParser : TypeParser<CachedRole>
    {
        public static CachedRoleParser Instance => _instance ?? (_instance = new CachedRoleParser());

        private static CachedRoleParser _instance;

        private CachedRoleParser()
        { }

        public override ValueTask<TypeParserResult<CachedRole>> ParseAsync(Parameter parameter, string value, CommandContext context)
        {
            var Context = (DiscordCommandContext) context;
            if (Context.Guild == null)
                return new TypeParserResult<CachedRole>("This command must be used a guild.");

            CachedRole role = null;
            if (Discord.TryParseRoleMention(value, out var id) || Snowflake.TryParse(value, out id))
                Context.Guild.Roles.TryGetValue(id, out role);

            if (role == null)
                role = Context.Guild.Roles.Values.FirstOrDefault(x => x.Name == value);

            return role == null
                ? new TypeParserResult<CachedRole>("No role found matching the input.")
                : new TypeParserResult<CachedRole>(role);
        }
    }
}