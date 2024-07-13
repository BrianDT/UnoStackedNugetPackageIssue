namespace Vssl.Sample.Package2;

using Vssl.Sample.Package1;

public class P2
{
    private P1 p1;

    public P2()
    {
        this.p1 = new P1();
    }

    public double Y => this.p1.X;
}
