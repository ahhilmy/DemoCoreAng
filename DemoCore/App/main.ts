import { platformBrowserDynamic } from '@angular/platform-browser-dynamic'
import { AppModule } from './app.module'

//tell angular that we have to bootstrap the app with the AppModule
//one time -- dont have to do this for every component
platformBrowserDynamic().bootstrapModule(AppModule)
