﻿using System;

namespace HeadlessTweaks
{
    partial class MessageCommands
    {
        // Command Attributes
        // Name: The name of the command
        // Description: The description of the command
        // PermissionLevel: The permission level required to use the command
        // Alliases: The aliases of the command
        // Usage: The arguments of the command

        internal class CommandAttribute : Attribute
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public PermissionLevel PermissionLevel { get; set; }
            public string[] Aliases { get; set; }
            public string Usage { get; set; }


            public CommandAttribute(string name, string description, PermissionLevel permissionLevel = PermissionLevel.None, string usage = null, params string[] aliases)
            {
                Name = name;
                Description = description;
                PermissionLevel = permissionLevel;
                Aliases = aliases;
                Usage = usage;
            }
        }
    }
}
