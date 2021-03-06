﻿using Jarilo.Tokenizing;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jarilo.Metadata
{
    class CommandMetadata
    {
        public string Name { get; }
        public string Description { get; }
        public Func<Token[], object> ArgumentsFactory { get; }
        public Func<Token[], object> OptionsFactory { get; }
        public Func<Token[], Task> Run { get; }
        public ArgumentMetadata[] Arguments { get; }
        public OptionMetadata[] Options { get; }
        public ViewMetadata View { get; }
        public Func<object> Factory { get; }

        public CommandMetadata(
            string name,
            string description,
            ArgumentMetadata[] arguments,
            OptionMetadata[] options,
            ViewMetadata view,
            Func<object> factory,
            Func<Token[], object> argumentsFactory,
            Func<Token[], object> optionsFactory,
            Func<Token[], Task> run)
        {
            Name = name;
            Description = description;
            Arguments = arguments;
            Options = options;
            Run = run;
            ArgumentsFactory = argumentsFactory;
            OptionsFactory = optionsFactory;
            View = view;
            Factory = factory;
        }
    }
}
