# xamarin-forms-book-samples

Sample code for the book *Creating Mobile Apps with Xamarin.Forms*. The book can be downloaded from https://docs.microsoft.com/en-us/xamarin/xamarin-forms/creating-mobile-apps-xamarin-forms/.

# Glossary
|     |     |     |
| --- | --- | --- |
| 01 [How does Xamarin.Forms fit in?](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter01/PlatformVisuals) | 11 The bindable infrastructure | 21 Transforms |
| 02 [Anatomy of an app](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter02) | 12 Styles | 22 Animation |
| 03 [Deeper into text](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter03)| 13 Bitmaps | 23 Triggers and behaviors |
| 04 [Scrolling the stack](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter04)| 14 Absolute layout | 24 Page navigation |
| 05 [Dealing with sizes](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter05) | 15 The interactive interface | 25 Page varieties |
| 06 [Button clicks](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter06) | 16 Data binding | 26 Custom layouts |
| 07 [XAML vs. code](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter07) | 17 Mastering the Grid | 27 Custom renderers |
| 08 [Code and XAML in harmony](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter08) | 18 MVVM | 28 Location and Maps |
| 09 [Platform-specific API calls](https://github.com/UncleCShark/Xamarin-Examples/tree/master/Chapter09) | 19 Collection views | 
| 10 XAML markup extensions | 20 Async and file I/O |

# Getting Started

## Prerequisites to run the samples
- Install any version of [Microsoft Visual Studio](https://www.visualstudio.com/) 2017

## Notes
This is a fork of https://github.com/xamarin/xamarin-forms-book-samples as at April 17, 2018. The samples use package references (PackageReference) , Net Standard 2.0 or Portable Class Library (for Xamarin.Forms projects).
The UWP projects are built with Windows 10 Fall Creators Update 10.0 Build Number 16299. The projects were build using Visual Studio Community 2017.

### The Projects

These solutions contain three application projects:

- **iOS**: iPhone and iPads
- **Droid**: Android phones and tablets
- **UWP**: The Universal Windows Platform, targeting Windows 10 tablets and desktop computers, and Windows 10 Mobile

and two Xamarin.Forms projects

- **.Portable**: Portable Class Library
- **.NetStandard**: NetStandard 2.0 Class Library

You can change references in the application projects to switch variant of Xamarin Forms
