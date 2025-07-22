import { ModuleWithProviders, NgModule } from '@angular/core';
import { TEST2_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class test2ConfigModule {
  static forRoot(): ModuleWithProviders<test2ConfigModule> {
    return {
      ngModule: test2ConfigModule,
      providers: [TEST2_ROUTE_PROVIDERS],
    };
  }
}
