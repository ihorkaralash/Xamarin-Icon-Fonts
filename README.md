# Icon fonts for Xamarin.Android and Xamarin.iOS

Use icon fonts in your Xamarin.Android and Xamarin.iOS applications!

Based on https://github.com/jsmarcus/Iconize

![alt text](https://github.com/ihorkaralash/Xamarin-Icon-Fonts/blob/master/art/android.png)![alt text](https://github.com/ihorkaralash/Xamarin-Icon-Fonts/blob/master/art/ios.png)

## Controls

* IconButton (Button)
* IconImage (Image)
* IconLabel (Label)

## Configure

**Xamarin.Android (AppCompat)**  
Initialize the IconControls in MainApplication.

```csharp
public override void OnCreate()
{
  base.OnCreate();
                
  Plugin.IconFonts.IconFonts.With(new EntypoPlusModule())
    .With(new FontAwesomeRegularModule())
    .With(new FontAwesomeBrandsModule())
    .With(new FontAwesomeSolidModule());
    .With(new IoniconsModule())
    .With(new MaterialModule())
    .With(new MaterialDesignIconsModule())
    .With(new MeteoconsModule())
    .With(new SimpleLineIconsModule())
    .With(new TypiconsModule())
    .With(new WeatherIconsModule());
}
```

**Xamarin.iOS (Unified)**  
Add the UIAppFonts key to Info.plist with the specific fonts you have chosen.

```xml
<key>UIAppFonts</key>
<array>
  <string>iconfonts-entypoplus.ttf</string>
  <string>iconfonts-fontawesome-regular.ttf</string>
  <string>iconfonts-fontawesome-solid.ttf</string>
  <string>iconfonts-fontawesome-brands.ttf</string>
  <string>iconfonts-ionicons.ttf</string>
  <string>iconfonts-jam-icons.ttf</string>
  <string>iconfonts-material.ttf</string>
  <string>iconfonts-meteocons.ttf</string>
  <string>iconfonts-simplelineicons.ttf</string>
  <string>iconfonts-typicons.ttf</string>
  <string>iconfonts-weathericons.ttf</string>
</array>
```
Initialize the IconControls in AppDelegate.

```csharp
public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
{
    Plugin.IconFonts.IconFonts.With(new EntypoPlusModule())
        .With(new FontAwesomeRegularModule())
        .With(new FontAwesomeBrandsModule())
        .With(new FontAwesomeSolidModule());
        .With(new IoniconsModule())
        .With(new MaterialModule())
        .With(new MaterialDesignIconsModule())
        .With(new MeteoconsModule())
        .With(new SimpleLineIconsModule())
        .With(new TypiconsModule())
        .With(new WeatherIconsModule());

    return true;
}
```

## Using

**Xamarin.Android (AppCompat)**

**Image**

```xml
<Plugin.IconFonts.IconImage
	android:layout_width="50dp"
	android:layout_height="50dp"
	app:Icon="fab-android"
	app:IconColor="@android:color/black"/>
```

**Button**

```xml
<Plugin.IconFonts.IconButton
	android:layout_width="wrap_content"
	android:layout_height="wrap_content"
	android:paddingLeft="20dp"
	android:paddingRight="20dp"
	android:text="{fab-google-plus-g} Google"
	android:textSize="20dp"
	android:textColor="@android:color/white"
	android:backgroundTint="@color/googleBackground"/>
```

**Label**

```xml
<Plugin.IconFonts.IconLabel
	android:layout_width="wrap_content"
	android:layout_height="wrap_content"
	android:text="Click on any button above {fas-level-up-alt}"
	android:textColor="@android:color/black"/>
```

**Custom style**

```csharp
[Register("Plugin.IconFonts.CustomIconLabel")]
public class CustomIconLabel : IconLabel
{
    public Color IconColor { get; set; }

    public CustomIconLabel(Context context, IAttributeSet attrs) : base(context, attrs)
    {
       IconColor = TextColor;
    }

    public override ISpannable ParseIcons()
    {
       var text = base.ParseIcons();

       text.SetSpan(new ForegroundColorSpan(IconColor), 0, 1, SpanTypes.ExclusiveInclusive);

       return text;
    }
}
```

**Xamarin.iOS (Unified)**  

**Image**

![alt text](https://github.com/ihorkaralash/Xamarin-Icon-Fonts/blob/master/art/ios-image.png)

**Button**

![alt text](https://github.com/ihorkaralash/Xamarin-Icon-Fonts/blob/master/art/ios-button.png)

**Label**

![alt text](https://github.com/ihorkaralash/Xamarin-Icon-Fonts/blob/master/art/ios-label.png)

**Custom style**

```csharp
[Register("CustomIconLabel")]
public class CustomIconLabel : IconLabel
{
    public UIColor IconColor { get; set; }
	
    public CustomIconLabel(IntPtr handle) : base(handle)
    {

    }

    public CustomIconLabel()
    {

    }

    public override NSAttributedString ParseIcons()
    {
        var text = (NSMutableAttributedString)base.ParseIcons();

        text.AddAttributes(new UIStringAttributes { ForegroundColor = IconColor }, new NSRange(0, 1));

        return text;
    }
}
```

