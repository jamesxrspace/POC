/* tslint:disable */
/* eslint-disable */
/**
 * Server API - Login
 * The Restful APIs of Login.
 *
 * The version of the OpenAPI document: 1.0.0
 *
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 *
 * @export
 * @interface ModelFile
 */
export interface ModelFile {
  /**
   * unique file id(file name)
   * @type {string}
   * @memberof ModelFile
   */
  fileId: string;
  /**
   * file content type
   * @type {string}
   * @memberof ModelFile
   */
  contentType: string;
  /**
   * file content length(bytes)
   * @type {number}
   * @memberof ModelFile
   */
  contentLength: number;
  /**
   * file checksum(sha256 base64 encoded)
   * @type {string}
   * @memberof ModelFile
   */
  checksum: string;
}

/**
 * Check if a given object implements the ModelFile interface.
 */
export function instanceOfModelFile(value: object): boolean {
  let isInstance = true;
  isInstance = isInstance && 'fileId' in value;
  isInstance = isInstance && 'contentType' in value;
  isInstance = isInstance && 'contentLength' in value;
  isInstance = isInstance && 'checksum' in value;

  return isInstance;
}

export function ModelFileFromJSON(json: any): ModelFile {
  return ModelFileFromJSONTyped(json, false);
}

export function ModelFileFromJSONTyped(json: any, ignoreDiscriminator: boolean): ModelFile {
  if (json === undefined || json === null) {
    return json;
  }
  return {
    fileId: json['file_id'],
    contentType: json['content_type'],
    contentLength: json['content_length'],
    checksum: json['checksum'],
  };
}

export function ModelFileToJSON(value?: ModelFile | null): any {
  if (value === undefined) {
    return undefined;
  }
  if (value === null) {
    return null;
  }
  return {
    file_id: value.fileId,
    content_type: value.contentType,
    content_length: value.contentLength,
    checksum: value.checksum,
  };
}
