using Autofac;
using DependencyInjection.Console.CharacterWriters;
using DependencyInjection.Console.SquarePainters;

namespace DependencyInjection.Console
{
    class ProgramModule : Module
    {
        private readonly bool _useColors;
        private readonly string _pattern;

        public ProgramModule(bool useColors, string pattern)
        {
            _useColors = useColors;
            _pattern = pattern;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(GetCharacterWriter(_useColors));
            builder.RegisterType<PatternWriter>();
            builder.RegisterType<CircleSquarePainter>().Named<ISquarePainter>("circle");
            builder.RegisterType<OddEvenSquarePainter>().Named<ISquarePainter>("oddeven");
            builder.RegisterType<WhiteSquarePainter>().Named<ISquarePainter>("white");
            builder.Register(c => c.ResolveNamed<ISquarePainter>(_pattern));
            builder.RegisterType<PatternGenerator>();
            builder.RegisterType<PatternApp>();
        }
        private static ICharacterWriter GetCharacterWriter(bool useColors)
        {
            var writer = new AsciiWriter();
            return useColors ? (ICharacterWriter)new ColorWriter(writer) : writer;
        }
    }
}
