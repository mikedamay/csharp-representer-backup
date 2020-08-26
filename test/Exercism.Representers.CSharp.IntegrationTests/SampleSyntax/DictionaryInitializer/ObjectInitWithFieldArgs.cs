using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Exercism.Representers.CSharp.IntegrationTests.SampleSyntax.DictionaryInitializer
{
    public class ObjectInitWithFieldArgs
    {
        const int nn = 1;
        static string ss = "one";

        Dictionary<int, string> dict = new Dictionary<int, string> {[nn] = ss};

        private SyntaxNode node = CompilationUnit()
            .WithMembers(
                List<MemberDeclarationSyntax>(
                    new MemberDeclarationSyntax[]
                    {
                        FieldDeclaration(
                                VariableDeclaration(
                                        PredefinedType(
                                            Token(SyntaxKind.IntKeyword)))
                                    .WithVariables(
                                        SingletonSeparatedList<VariableDeclaratorSyntax>(
                                            VariableDeclarator(
                                                    Identifier("nn"))
                                                .WithInitializer(
                                                    EqualsValueClause(
                                                        LiteralExpression(
                                                            SyntaxKind.NumericLiteralExpression,
                                                            Literal(1)))))))
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.ConstKeyword))),
                        FieldDeclaration(
                                VariableDeclaration(
                                        PredefinedType(
                                            Token(SyntaxKind.StringKeyword)))
                                    .WithVariables(
                                        SingletonSeparatedList<VariableDeclaratorSyntax>(
                                            VariableDeclarator(
                                                    Identifier("ss"))
                                                .WithInitializer(
                                                    EqualsValueClause(
                                                        LiteralExpression(
                                                            SyntaxKind.StringLiteralExpression,
                                                            Literal("one")))))))
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.StaticKeyword))),
                        FieldDeclaration(
                            VariableDeclaration(
                                    GenericName(
                                            Identifier("Dictionary"))
                                        .WithTypeArgumentList(
                                            TypeArgumentList(
                                                SeparatedList<TypeSyntax>(
                                                    new SyntaxNodeOrToken[]
                                                    {
                                                        PredefinedType(
                                                            Token(SyntaxKind.IntKeyword)),
                                                        Token(SyntaxKind.CommaToken),
                                                        PredefinedType(
                                                            Token(SyntaxKind.StringKeyword))
                                                    }))))
                                .WithVariables(
                                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                                        VariableDeclarator(
                                                Identifier("dict"))
                                            .WithInitializer(
                                                EqualsValueClause(
                                                    ObjectCreationExpression(
                                                            GenericName(
                                                                    Identifier("Dictionary"))
                                                                .WithTypeArgumentList(
                                                                    TypeArgumentList(
                                                                        SeparatedList<TypeSyntax>(
                                                                            new SyntaxNodeOrToken[]
                                                                            {
                                                                                PredefinedType(
                                                                                    Token(SyntaxKind.IntKeyword)),
                                                                                Token(SyntaxKind.CommaToken),
                                                                                PredefinedType(
                                                                                    Token(SyntaxKind.StringKeyword))
                                                                            }))))
                                                        .WithInitializer(
                                                            InitializerExpression(
                                                                SyntaxKind.ObjectInitializerExpression,
                                                                SingletonSeparatedList<ExpressionSyntax>(
                                                                    AssignmentExpression(
                                                                        SyntaxKind.SimpleAssignmentExpression,
                                                                        ImplicitElementAccess()
                                                                            .WithArgumentList(
                                                                                BracketedArgumentList(
                                                                                    SingletonSeparatedList<
                                                                                        ArgumentSyntax>(
                                                                                        Argument(
                                                                                            IdentifierName("nn"))))),
                                                                        IdentifierName("ss"))))))))))
                    }))
            .NormalizeWhitespace();
    }
}

/*
IObjectOrCollectionInitializationOperation (InitializerExpressionSyntax)
    ISimpleAssignmentOperation (AssignmentExpressionSyntax)
        IPropertyReferenceOperation (ImplicitElementAccessSyntax)
            IInstanceReferenceOperation (ImplicitElementAccessSyntax)
            IArgumentOperation (ArgumentSyntax)
                IFieldReferenceOperation (IdentifierNameSyntax)
        IFieldReferenceOperation (IdentifierNameSyntax)
*/