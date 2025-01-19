int mm = 42;
int result = (int)this.Invoke(new Func<int, int>((x) =>
{
    x += mm; // Add `mm` to `x`
    return x; // Return the processed value
}), 10); // Passing `10` as the argument for `x`

MessageBox.Show($"Result: {result}");
