using System;

namespace Sharper.C.Data
{

using static UnitModule;

public static class FunctionModule
{
    public static Func<A, B> Fun<A, B>(Func<A, B> f)
    =>
        f;

    public static Func<A, Unit> Fun<A>(Action<A> f)
    =>
        ToFunc(f);

     public static Action<A> Act<A>(Action<A> f)
     =>
        f;

    public static A Id<A>(A a)
    =>
        a;

    public static Func<B, A> Const<A, B>(A a)
    =>
        b => a;

    public static Func<B, A, C> Flip<A, B, C>(Func<A, B, C> f)
    =>
        (b, a) => f(a, b);

    public static Func<A, C> Compose<A, B, C>(this Func<B, C> f, Func<A, B> g)
    =>
        a => f(g(a));

    public static Func<A, C> Then<A, B, C>(this Func<A, B> f, Func<B, C> g)
    =>
        a => g(f(a));

    public static Func<A, Func<B, C>> Curry<A, B, C>(Func<A, B, C> f)
    =>
        a => b => f(a, b);

    public static Func<A, B, C> Uncurry<A, B, C>(Func<A, Func<B, C>> f)
    =>
        (a, b) => f(a)(b);
}

}
