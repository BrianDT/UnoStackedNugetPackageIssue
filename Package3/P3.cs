namespace Vssl.Sample.Package3;

using Vssl.Sample.Package2;

public class P3
    {
    private P2 p2;

    public P3()
    {
        this.p2 = new P2();
    }

    public double Z => this.p2.Y;
}
