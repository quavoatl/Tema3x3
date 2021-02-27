﻿using System;
using Tema3x3.BaseComponents;
using Tema3x3.Helpers;

namespace Tema3x3.ConcreteComponents.Numbers
{
    public sealed class Four : RepresentationBase
    {
        private static RepresentationBase Instance;

        public static RepresentationBase GetInstance()
        {
            if (Instance == null)
            {
                return new Four();
            }

            return Instance;
        }

        private Four() { }

        private string _numberRepresentation_Head = Constants.DOT + Constants.DOT + Constants.DOT + " ";
        private string _numberRepresentation_Body = Constants.PIPE + Constants.UNDERSCORE + Constants.PIPE + " ";
        private string _numberRepresentation_Footer = Constants.DOT + Constants.DOT + Constants.PIPE + " ";

        public override string Head { get => _numberRepresentation_Head; set => _numberRepresentation_Head = value; }
        public override string Body { get => _numberRepresentation_Body; set => _numberRepresentation_Body = value; }
        public override string Footer { get => _numberRepresentation_Footer; set => _numberRepresentation_Footer = value; }

    }
}