﻿using System;
using Tema3x3.BaseComponents;
using Tema3x3.Helpers;

namespace Tema3x3.ConcreteComponents.Numbers
{
    public sealed class Nine : RepresentationBase
    {
        private static RepresentationBase Instance;

        public static RepresentationBase GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Nine();
            }

            return Instance;
        }

        private Nine() { }

        private string _numberRepresentation_Head = Characters.DOT + Characters.UNDERSCORE + Characters.DOT + " ";
        private string _numberRepresentation_Body = Characters.PIPE + Characters.UNDERSCORE + Characters.PIPE + " ";
        private string _numberRepresentation_Footer = Characters.DOT + Characters.DOT + Characters.PIPE + " ";

        public override string Head { get => _numberRepresentation_Head; set => _numberRepresentation_Head = value; }
        public override string Body { get => _numberRepresentation_Body; set => _numberRepresentation_Body = value; }
        public override string Footer { get => _numberRepresentation_Footer; set => _numberRepresentation_Footer = value; }

    }
}