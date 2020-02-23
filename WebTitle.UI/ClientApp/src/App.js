import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import SearchTitle from './components/SearchTitle';
import TitleView from './components/TitleView';

export default () => (
  <Layout>
    <Route exact path='/' component={SearchTitle} />
    <Route path='/title/:titleId?' component={TitleView} />
  </Layout>
);
